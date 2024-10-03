
using AutoMapper;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using static FusionTech.src.DTO.VideoGameInfoDTO;

namespace FusionTech.src.Services.VideoGamesInfo
{
    public class VideoGameInfoService : IVideoGameInfoService
    {
        protected readonly VideoGameInfoRepository _videoGameInfoRepo;
        protected readonly IMapper _mapper;

        public VideoGameInfoService(VideoGameInfoRepository videoGameInfoRepository, IMapper mapper)
        {
            _videoGameInfoRepo = videoGameInfoRepository;
            _mapper = mapper;
        }

        public async Task<VideoGameInfoReadDto> CreateOneAsync(VideoGameInfoCreateDto createGameInfo)
        {
            var videoGame = _mapper.Map<VideoGameInfoCreateDto, VideoGameInfo>(createGameInfo);
            var createdGameInfo = await _videoGameInfoRepo.CreateOneAsync(videoGame);
            return _mapper.Map<VideoGameInfo, VideoGameInfoReadDto>(createdGameInfo);
        }

        public async Task<bool> DeleteAsync(Guid id)
        {
            var foundGameInfo = await _videoGameInfoRepo.GetByIdAsync(id);
            if (foundGameInfo == null)
            {
                return false;
            }

            return await _videoGameInfoRepo.DeleteOnAsync(foundGameInfo);
        }

        public async Task<List<VideoGameInfoReadDto>> GetAllAsync()
        {
            var videoGameList = await _videoGameInfoRepo.GetAllAsync();
            return _mapper.Map<List<VideoGameInfo>, List<VideoGameInfoReadDto>>(videoGameList);
        }

        public async Task<VideoGameInfoReadDto> GetByIdAsync(Guid id)
        {
            var foundGameInfo = await _videoGameInfoRepo.GetByIdAsync(id);
            return _mapper.Map<VideoGameInfo, VideoGameInfoReadDto>(foundGameInfo);
        }

        public async Task<bool> UpdateOnAsync(Guid id, VideoGameInfoUpdateDto updateGameInfo)
        {
            var foundGameInfo = await _videoGameInfoRepo.GetByIdAsync(id);
            if (foundGameInfo == null)
            {
                return false;
            }

            _mapper.Map(updateGameInfo, foundGameInfo);
            return await _videoGameInfoRepo.UpdateOnAsync(foundGameInfo);
        }
    }
}
