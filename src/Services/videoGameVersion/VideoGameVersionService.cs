using AutoMapper;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using FusionTech.src.Utils;
using FusionTech.videoGameVersion;
using static FusionTech.src.DTO.VideoGameVersionDTO;

namespace FusionTech.src.Services.videoGameVersion
{
    public class VideoGameVersionService : IVideoGameVersionService
    {
        protected readonly VideoGameVersionRepository _videoGameVersionRepo;
        protected readonly IMapper _mapper;

        public VideoGameVersionService(VideoGameVersionRepository videoGameVersionRepository, IMapper mapper)
        {
            _videoGameVersionRepo = videoGameVersionRepository;
            _mapper = mapper;
        }

        public async Task<VideoGameVersionReadDto> CreateOneAsync(VideoGameVersionCreateDto createGameVersion)
        {
            var videoGame = _mapper.Map<VideoGameVersionCreateDto, VideoGameVersion>(createGameVersion);
            var createdGameVersion = await _videoGameVersionRepo.CreateOneAsync(videoGame);
            return _mapper.Map<VideoGameVersion, VideoGameVersionReadDto>(createdGameVersion);
        }

        public async Task<bool> DeleteOneAsync(Guid id)
        {
            var foundGameInfo = await _videoGameVersionRepo.GetVersionByIdAsync(id);
            if (foundGameInfo == null)
            {
                return false;
            }

            return await _videoGameVersionRepo.DeleteOneAsync(foundGameInfo);
        }

        public async Task<List<VideoGameVersionReadDto>> GetAllAsync( )
        {
            var videoGameList = await _videoGameVersionRepo.GetAllAsync();
            return _mapper.Map<List<VideoGameVersion>, List<VideoGameVersionReadDto>>(videoGameList);
        }

        public async Task<VideoGameVersionReadDto> GetVersionByIdAsync(Guid id)
        {
            var foundGameVersion = await _videoGameVersionRepo.GetVersionByIdAsync(id);
            return _mapper.Map<VideoGameVersion, VideoGameVersionReadDto>(foundGameVersion);
        }

        public async Task<bool> UpdateOneAsync(Guid id, VideoGameVersionUpdateDto updateGameVersion)
        {
            var foundGameVersion = await _videoGameVersionRepo.GetVersionByIdAsync(id);
            if (foundGameVersion == null)
            {
                return false;
            }

            _mapper.Map(updateGameVersion, foundGameVersion);
            return await _videoGameVersionRepo.UpdateOneAsync(foundGameVersion);
        }
    }
}