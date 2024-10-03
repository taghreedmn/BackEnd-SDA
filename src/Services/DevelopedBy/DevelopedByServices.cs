using AutoMapper;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using static FusionTech.src.Entity.DevelopedByDTO;

namespace FusionTech.src.Services.DevelopedBy
{
    public class DevelopedByServices
    {
        protected  DevelopedByRepository _developedbyRepository;
        protected  IMapper _maper;

        public DevelopedByServices(DevelopedByRepository developedbyRepository, IMapper maper)
        {
            _developedbyRepository = developedbyRepository;
            _maper = maper;
        }

        public async Task<ReadDevelopedByDTO> CreateOneAsync(CreateDevelopedByDTO createDTO)
        {
            var developed = _maper.Map<CreateDevelopedByDTO,Developed>(createDTO);

            var developedCreated = await _developedbyRepository.CreateOneAsync(developed);

            return _maper.Map<Developed, ReadDevelopedByDTO>(developedCreated);
        }

        public async Task<List<ReadDevelopedByDTO>> GetAllAsync()
        {
            var Listdeveloped = await _developedbyRepository.GetAllAsync();
            return _maper.Map<List<Developed>, List<ReadDevelopedByDTO>>(Listdeveloped);
        }

        public async Task<ReadDevelopedByDTO> GetIdAsync(Guid id)
        {
            var founddeveloped = await _developedbyRepository.GetIdAsync(id);
            return _maper.Map<Developed, ReadDevelopedByDTO>(founddeveloped);
        }

        public async Task<bool> DeleteIdAsync(Guid id)
        {
            var foundDeveloped  = await _developedbyRepository.GetIdAsync(id);

            bool isDelete = await _developedbyRepository.DeleteOneAsync(foundDeveloped);
            return isDelete;
        }

        public async Task<bool> UpdateAsync(Guid id, CreateDevelopedByDTO updateDeveloped)
        {
            var founddeveloped = await _developedbyRepository.GetIdAsync(id);

            if (founddeveloped  == null)
            {
                return false;
            }
            _maper.Map(updateDeveloped, founddeveloped );
            return await _developedbyRepository.UpdateOneAsync(founddeveloped);
        }
        
    }

 

}