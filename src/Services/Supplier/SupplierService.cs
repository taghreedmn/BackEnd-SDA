using AutoMapper;
using FusionTech.src.Repository;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.SupplierDTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FusionTech.src.Services.supplier
{
    public class SupplierService : ISupplierService
    {
        private readonly SupplierRepository _supplierRepo;
        private readonly IMapper _mapper;

        public SupplierService(SupplierRepository supplierRepo, IMapper mapper)
        {
            _supplierRepo = supplierRepo;
            _mapper = mapper;
        }

        public async Task<SupplierReadDto> CreateOneAsync(SupplierCreateDto createDto)
        {
            var supplier = _mapper.Map<Supplier>(createDto);
            var supplierCreated = await _supplierRepo.CreateOneAsync(supplier);
            return _mapper.Map<SupplierReadDto>(supplierCreated);
        }

        public async Task<IEnumerable<SupplierReadDto>> GetAllAsync() {
            var supplierList = await _supplierRepo.GetAllAsync();
            return _mapper.Map<IEnumerable<SupplierReadDto>>(supplierList); 
        }

        public async Task<SupplierReadDto?> GetByIdAsync(Guid id)
        {
            var foundSupplier = await _supplierRepo.GetByIdAsync(id);
            return foundSupplier != null ? _mapper.Map<SupplierReadDto>(foundSupplier) : null;
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
