namespace FusionTech.src.Service.publisher
{
    public class PublisherService : IPublisherService
    {
        protected readonly PublisherRepository _publisherRepository;
        protected readonly IMapper _mapper; 

        public PublisherService(PublisherRepository publisherRepository, IMapper mapper)
        {
            _publisherRepository = publisherRepository;
            _mapper = mapper;
        }

        public async Task<PublisherReadDto> CreateOneAsync(PublisherCreateDto createDTO)
        {
            var publisher = _mapper.Map<PublisherCreateDto, Publisher>(createDTO);
            var publisherCreated = await _publisherRepository.CreateOneAsync(publisher);
            return _mapper.Map<Publisher, PublisherReadDto>(publisherCreated);
        }

        public async Task<List<PublisherReadDto>> GetAllAsync()
        {
            var listPublisher = await _publisherRepository.GetAllAsync();
            return _mapper.Map<List<Publisher>, List<PublisherReadDto>>(listPublisher);
        }

        public async Task<PublisherReadDto> GetByIdAsync(Guid id)
        {
            var foundPublisher = await _publisherRepository.GetIdAsync(id);
            return _mapper.Map<Publisher, PublisherReadDto>(foundPublisher);
        }

        public async Task<bool> DeleteOneAsync(Guid id)
        {
            var foundPublisher = await _publisherRepository.GetIdAsync(id);
            if (foundPublisher == null) return false; 

            return await _publisherRepository.DeleteOneAsync(foundPublisher);
        }

        public async Task<bool> UpdateOneAsync(Guid id, PublisherUpdateDto updateDto)
        {
            var foundPublisher = await _publisherRepository.GetIdAsync(id);
            if (foundPublisher == null) return false; 

            _mapper.Map(updateDto, foundPublisher); 
            return await _publisherRepository.UpdateOneAsync(foundPublisher);
        }
    }
}
