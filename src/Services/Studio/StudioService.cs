using AutoMapper;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using static FusionTech.src.DTO.StudioDTO;

namespace FusionTech.src.Service.Studio
{
    public class StudioService : IStudioService
    {
        protected readonly StudioRepository _studioRepository;
        protected readonly IMapper _maper;

        public StudioService(StudioRepository studioRepository, IMapper maper)
        {
            _studioRepository = studioRepository;
            _maper = maper;
        }

        public async Task<ReadStudioDTO> CreateOneAsync(CreatStudioDTO createDTO)
        {
            var studio = _maper.Map<CreatStudioDTO, GameStudio>(createDTO);

            var studioCreated = await _studioRepository.CreateOneAsync(studio);

            return _maper.Map<GameStudio, ReadStudioDTO>(studioCreated);
        }

        public async Task<List<ReadStudioDTO>> GetAllAsync()
        {
            var Liststudio = await _studioRepository.GetAllAsync();
            return _maper.Map<List<GameStudio>, List<ReadStudioDTO>>(Liststudio);
        }

        public async Task<ReadStudioDTO> GetIdAsync(Guid id)
        {
            var foundstudio = await _studioRepository.GetIdAsync(id);
            return _maper.Map<GameStudio, ReadStudioDTO>(foundstudio);
        }

        public async Task<bool> DeleteIdAsync(Guid id)
        {
            var foundstudio = await _studioRepository.GetIdAsync(id);

            bool isDelete = await _studioRepository.DeleteOneAsync(foundstudio);
            return isDelete;
        }

        public async Task<bool> UpdateAsync(Guid id, UpdateStudioDTO studioName)
        {
            var foundstudio = await _studioRepository.GetIdAsync(id);
            var Updatestudio = await _studioRepository.UpdateOneAsync(foundstudio);
            if (foundstudio == null)
            {
                return false;
            }
            _maper.Map(Updatestudio, foundstudio);
            return await _studioRepository.UpdateOneAsync(foundstudio);
        }
    }
}
