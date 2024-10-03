using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.VideoGameInfoDTO;

namespace FusionTech.src.Services.VideoGamesInfo
{
    public interface IVideoGameInfoService
    {

        Task<VideoGameInfoReadDto> CreateOneAsync(VideoGameInfoCreateDto newGameInfo);
        Task<List<VideoGameInfoReadDto>> GetAllAsync();
        Task<VideoGameInfoReadDto> GetByIdAsync(Guid id);
        Task<bool> UpdateOnAsync(Guid id, VideoGameInfoUpdateDto updateGameInfo);
        Task<bool> DeleteAsync(Guid id);
    }
}
