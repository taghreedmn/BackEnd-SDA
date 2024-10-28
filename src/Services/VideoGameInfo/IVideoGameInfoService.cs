namespace FusionTech.src.Services.VideoGamesInfo
{
    public interface IVideoGameInfoService
    {
        Task<VideoGameInfoReadDto> CreateOneAsync(VideoGameInfoCreateDto newGameInfo, string email);
        Task<List<VideoGameInfoReadDto>> GetAllAsync(SearchParameters searchParameters);
        Task<VideoGameInfoReadDtoWithVersions> GetByIdAsync(Guid id);
        Task<List<VideoGameInfoReadDtoWithVersions>> GetVideoGameVersionByIdAsync(Guid id);
        Task<List<VideoGameInfo>> GetVideoGameRatingsByIdAsync(Guid id);
        Task<bool> DeleteAsync(Guid id);
        Task<bool> UpdateGameNameAsync(Guid id, string newGameName);
        Task<bool> UpdateYearOfReleaseAsync(Guid id, string newYearOfRelease);
        //Task<bool> UpdateOnAsync(VideoGameInfoUpdateDto updatedVideoGameDto);
    }
}
