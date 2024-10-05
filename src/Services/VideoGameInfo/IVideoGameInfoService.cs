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

        Task<VideoGameInfoReadDto> CreateOneAsync(VideoGameInfoCreateDto newGameInfo,string email);
        Task<List<VideoGameInfoReadDto>> GetAllAsync();
        Task<VideoGameInfoReadDto> GetByIdAsync(Guid id);
        Task<List<VideoGameInfoReadDto>> GetVideoGameVersionByIdAsync(Guid id);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateGameNameAsync(Guid id, string newGameName);
        Task<bool> UpdateYearOfReleaseAsync(Guid id, string newYearOfRelease);
        //Task<bool> UpdateOnAsync(VideoGameInfoUpdateDto updatedVideoGameDto);
    }
}
