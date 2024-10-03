using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Utils;
using static FusionTech.src.DTO.VideoGameVersionDTO;

namespace FusionTech.videoGameVersion
{
    public interface IVideoGameVersionService
    {
        Task<VideoGameVersionReadDto> CreateOneAsync(VideoGameVersionCreateDto newGameVersion);
        Task<List<VideoGameVersionReadDto>> GetAllAsync();
        Task<VideoGameVersionReadDto> GetVersionByIdAsync(Guid id);
        Task<bool> UpdateOneAsync(Guid id, VideoGameVersionUpdateDto updateGameVersion);
        Task<bool> DeleteOneAsync(Guid id);
    }
}