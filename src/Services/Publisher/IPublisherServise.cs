namespace FusionTech.src.Services.Publisher
{
    public interface IPublisherService
    {
        Task<PublisherReadDto> CreateOneAsync(PublisherCreateDto createDto);
        Task<List<PublisherReadDto>> GetAllAsync();
        Task<PublisherReadDto> GetByIdAsync(Guid id);
        Task<bool> DeleteOneAsync(Guid id);
        Task<bool> UpdateOneAsync(Guid id, PublisherUpdateDto updateDto);
    }
}
