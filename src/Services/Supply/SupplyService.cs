using AutoMapper;
using FusionTech.src.DTO;
using FusionTech.src.Repository;
using FusionTech.src.Entity;
using static FusionTech.src.DTO.SupplyDTO;
using FusionTech.src.Utils;
using Microsoft.EntityFrameworkCore.Metadata;
using static FusionTech.src.DTO.SupplyReadDto;



namespace FusionTech.src.Services.supply
{
   
    public class SupplyService : ISupplyService 
    {
        protected readonly SupplyRepository _supplyRepo;
        protected readonly IMapper _mapper;
        public SupplyService(SupplyRepository supplyRepo, IMapper mapper)
        {
            _supplyRepo = supplyRepo;
            _mapper = mapper;

        }
        public async Task<SupplyReadDto> CreateOneAsync(SupplyCreateDto createDto)
        {
            var supply = _mapper.Map<SupplyCreateDto, Supply>(createDto);

            var supplyCreated = await _supplyRepo.CreateOneAsync(supply);

           return _mapper.Map<Supply, SupplyReadDto>(supplyCreated);

        }
        public async Task<List<SupplyReadDto>> GetAllAsync(PaginationOptions paginationOptions)
         {
             var supplyList = await _supplyRepo.GetAllAsync(paginationOptions);
             return _mapper.Map<List<Supply>, List<SupplyReadDto>>(supplyList);
         }
        public async Task<SupplyReadDto> GetByIdAsync(Guid ID)
        {
           var foundSupply = await _supplyRepo.GetByIdAsync(ID);
           return _mapper.Map<Supply, SupplyReadDto>(foundSupply);
        }
   
        public async Task<bool> DeleteOneAsync(Guid ID)
        {
           var foundSupply = await _supplyRepo.GetByIdAsync(ID);
           bool isDeleted = await _supplyRepo.DeleteOneAsync(foundSupply);

           if (isDeleted)
           {
            return true;
           }
            return false;
        }
             
       
        public async Task<bool> UpdateOnAsync(Guid ID, SupplyUpdateDto updateDto)
        {
            var foundSupply = await _supplyRepo.GetByIdAsync(ID);
           

            if (foundSupply == null)
            {
                return false;
            }
             _mapper.Map(updateDto, foundSupply);

             return await _supplyRepo.UpdateOneAsync(foundSupply);

        

        }

        

      
    }
}