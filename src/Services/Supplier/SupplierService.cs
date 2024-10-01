using AutoMapper;
using FusionTech.src.Repository;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.SupplierDTO;

namespace FusionTech.src.Services.supplier
{
    public class SupplierService : ISupplierService
    {
        protected readonly SupplierRepository _supplierRepo;
        protected readonly IMapper _mapper;

        public SupplierService(SupplierRepository supplierRepo, IMapper mapper)
        {
            _supplierRepo = supplierRepo;
            _mapper = mapper;
        }

        public async Task<SupplierReadDto> CreateOneAsync(SupplierCreateDto createDto)
        {
            var supplier = _mapper.Map<SupplierCreateDto, Supplier>(createDto);
            var supplierCreated = await _supplierRepo.CreateOneAsync(supplier);
            return _mapper.Map<Supplier, SupplierReadDto>(supplierCreated);
        }

        public async Task<List<SupplierReadDto>> GetAllAsync()
        {
            var supplierList = await _supplierRepo.GetAllAsync();
            return _mapper.Map<List<Supplier>, List<SupplierReadDto>>(supplierList);
        }

        public async Task<SupplierReadDto> GetByIdAsync(Guid id)
        {
            var foundSupplier = await _supplierRepo.GetByIdAsync(id);
            return _mapper.Map<Supplier, SupplierReadDto>(foundSupplier);
        }

        public async Task<bool> DeleteOneAsync(Guid id)
        {
            var foundSupplier = await _supplierRepo.GetByIdAsync(id);
            if (foundSupplier == null) return false;

            return await _supplierRepo.DeleteOneAsync(foundSupplier);
        }

        public async Task<bool> UpdateOneAsync(Guid id, SupplierUpdateDto updateDto)
        {
            var foundSupplier = await _supplierRepo.GetByIdAsync(id);
            if (foundSupplier == null) return false;

            _mapper.Map(updateDto, foundSupplier);
            return await _supplierRepo.UpdateOneAsync(foundSupplier);
        }
    }
}
