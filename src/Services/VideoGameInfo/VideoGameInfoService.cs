using System.Security.Authentication;
using AutoMapper;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.VideoGameInfoDTO;

namespace FusionTech.src.Services.VideoGamesInfo
{
    public class VideoGameInfoService : IVideoGameInfoService
    {
        protected readonly VideoGameInfoRepository _videoGameInfoRepo;
        protected readonly SystemAdminRepository _systemAdminRepository;
        protected readonly PersonRepository _personRepo;

        protected readonly IMapper _mapper;

        public VideoGameInfoService(
            VideoGameInfoRepository videoGameInfoRepository,
            PersonRepository personRepo,
            SystemAdminRepository systemAdminRepository,
            IMapper mapper
        )
        {
            _videoGameInfoRepo = videoGameInfoRepository;
            _mapper = mapper;
            _personRepo = personRepo;
            _systemAdminRepository = systemAdminRepository;
        }

        public async Task<VideoGameInfoReadDto> CreateOneAsync(
            VideoGameInfoCreateDto createGameInfo,
            string email
        )
        {
            var originalPerson = await _personRepo.FindPersonByEmail(email);
            var originalSystemAdmin = await _systemAdminRepository.GetByIdAsync(
                originalPerson!.PersonId
            );
            if (originalPerson == null)
            {
                throw CustomException.NotFound("Person not found.");
            }

            if (originalSystemAdmin!.ManageGames)
            {
                throw CustomException.UnAuthorized("Unauthorized access to manage games.");
            }

            var videoGame = _mapper.Map<VideoGameInfoCreateDto, VideoGameInfo>(createGameInfo);
            var createdGameInfo = await _videoGameInfoRepo.CreateOneAsync(videoGame);

            if (createdGameInfo == null)
            {
                throw CustomException.InternalError("Failed to create the video game.");
            }

            return _mapper.Map<VideoGameInfo, VideoGameInfoReadDto>(createdGameInfo);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var foundGameInfo = await _videoGameInfoRepo.GetByIdAsync(id);
            if (foundGameInfo == null)
            {
                throw CustomException.NotFound($"Video game with ID {id} not found.");
            }
            bool isDeleted = await _videoGameInfoRepo.DeleteOnAsync(foundGameInfo);
            if (!isDeleted)
            {
                throw CustomException.InternalError("Failed to delete the video game.");
            }
            return await _videoGameInfoRepo.DeleteOnAsync(foundGameInfo);
        }

        public async Task<List<VideoGameInfoReadDto>> GetAllAsync(SearchParameters searchParameters)
        {
            var videoGameList = await _videoGameInfoRepo.GetAllAsync();

            if (videoGameList == null || videoGameList.Count == 0)
            {
                throw CustomException.NotFound("No video games found.");
            }

            searchParameters.IsValid(); // Throws an error incase of a wrong parameters
            videoGameList = videoGameList
                .Where(a =>
                    a.GameName!.Contains(
                        searchParameters.Title!,
                        StringComparison.OrdinalIgnoreCase
                    )
                )
                .ToList();

            videoGameList = searchParameters.SortBy switch
            {
                SortingTypes.ByRating => searchParameters.Descending
                    ? videoGameList.OrderByDescending(vg => vg.TotalRating).ToList()
                    : videoGameList.OrderBy(vg => vg.TotalRating).ToList(),

                SortingTypes.ByTitle => searchParameters.Descending
                    ? videoGameList.OrderByDescending(vg => vg.GameName).ToList()
                    : videoGameList.OrderBy(vg => vg.GameName).ToList(),

                _ => videoGameList,
            };

            videoGameList = videoGameList
                .Skip(searchParameters.PaginationOptions.Offset)
                .Take(searchParameters.PaginationOptions.Limit)
                .ToList();

            return _mapper.Map<List<VideoGameInfo>, List<VideoGameInfoReadDto>>(videoGameList);
        }

        public async Task<VideoGameInfoReadDto> GetByIdAsync(Guid id)
        {
            var foundGameInfo = await _videoGameInfoRepo.GetByIdAsync(id);
            if (foundGameInfo == null)
            {
                throw CustomException.NotFound($"Video game with ID {id} not found.");
            }
            return _mapper.Map<VideoGameInfo, VideoGameInfoReadDto>(foundGameInfo);
        }

        public async Task<List<VideoGameInfoReadDto>> GetVideoGameVersionByIdAsync(Guid id)
        {
            var foundGameInfo = await _videoGameInfoRepo.GetVideoGameVersionByIdAsync(id);
            if (foundGameInfo == null || foundGameInfo.Count == 0)
            {
                throw CustomException.NotFound($"No video game versions found for ID {id}.");
            }
            return _mapper.Map<List<VideoGameInfo>, List<VideoGameInfoReadDto>>(foundGameInfo);
        }

        public async Task<bool> UpdateGameNameAsync(Guid id, string newGameName)
        {
            var videoGame = await _videoGameInfoRepo.GetByIdAsync(id);
            if (videoGame == null)
            {
                throw CustomException.NotFound($"Video game with ID {id} not found.");
            }
            videoGame.GameName = newGameName;
            bool isUpdated = await _videoGameInfoRepo.UpdateOnAsync(videoGame);
            if (!isUpdated)
            {
                throw CustomException.InternalError("Failed to update the game name.");
            }

            return await _videoGameInfoRepo.UpdateOnAsync(videoGame);
        }

        public async Task<bool> UpdateYearOfReleaseAsync(Guid id, string newYearOfRelease)
        {
            var videoGame = await _videoGameInfoRepo.GetByIdAsync(id);
            if (videoGame == null)
            {
                throw CustomException.NotFound($"Video game with ID {id} not found.");
            }

            videoGame.YearOfRelease = newYearOfRelease;
            bool isUpdated = await _videoGameInfoRepo.UpdateOnAsync(videoGame);
            if (!isUpdated)
            {
                throw CustomException.InternalError("Failed to update the year of release.");
            }

            return await _videoGameInfoRepo.UpdateOnAsync(videoGame);
        }
    }
}
