namespace FusionTech.src.Service.Store
{
    public class StoreService : IStoreService
    {
        protected readonly StoreRepository _storeRepo;
        protected readonly IMapper _mapper;

        public StoreService(StoreRepository storeRepo, IMapper mapper)
        {
            _storeRepo = storeRepo;
            _mapper = mapper;
        }

        public async Task<StoreReadDto> CreateOneAsync(StoreCreateDto storeCreateDto)
        {
            var store = _mapper.Map<Entity.Store>(storeCreateDto);
            var storeAdded = await _storeRepo.CreateOneAsync(store);
            return _mapper.Map<StoreReadDto>(storeAdded);
        }

        public async Task<List<StoreReadDto>> GetAllAsync()
        {
            var storeList = await _storeRepo.GetAllAsync();
            return _mapper.Map<List<StoreReadDto>>(storeList);
        }

        public async Task<StoreDetailedReadDto> GetByIdAsync(Guid id)
        {
            var foundStore = await _storeRepo.GetByIdAsync(id);
            if (foundStore == null)
            {
                throw CustomException.NotFound("Store not found");
            }
            return _mapper.Map<StoreDetailedReadDto>(foundStore);
        }

        public async Task<bool> UpdateOneAsync(StoreUpdateDto storeUpdateDto)
        {
            var foundStore = await _storeRepo.GetByIdAsync(storeUpdateDto.StoreId);
            if (foundStore == null)
                throw CustomException.NotFound("Store not found");

            _mapper.Map(storeUpdateDto, foundStore);
            return await _storeRepo.UpdateOneAsync(foundStore);
        }

        public async Task<bool> DeleteOneAsync(Guid id)
        {
            var foundStore = await _storeRepo.GetByIdAsync(id);
            if (foundStore == null)
                return false;

            return await _storeRepo.DeleteOneAsync(foundStore);
        }
    }
}
