namespace FusionTech.src.Services.Studio
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

        public async Task<StudioReadDTO> CreateOneAsync(StudioCreateDTO createDTO)
        {
            var studio = _maper.Map<StudioCreateDTO, GameStudio>(createDTO);

            var studioCreated = await _studioRepository.CreateOneAsync(studio);

            return _maper.Map<GameStudio, StudioReadDTO>(studioCreated);
        }

        public async Task<List<StudioReadDTO>> GetAllAsync()
        {
            var Liststudio = await _studioRepository.GetAllAsync();
            return _maper.Map<List<GameStudio>, List<StudioReadDTO>>(Liststudio);
        }

        public async Task<StudioReadDTO> GetIdAsync(Guid id)
        {
            var foundstudio = await _studioRepository.GetIdAsync(id);
            return _maper.Map<GameStudio, StudioReadDTO>(foundstudio);
        }

        public async Task<bool> DeleteIdAsync(Guid id)
        {
            var foundstudio = await _studioRepository.GetIdAsync(id);

            bool isDelete = await _studioRepository.DeleteOneAsync(foundstudio);
            return isDelete;
        }

        public async Task<bool> UpdateAsync(Guid id, StudioUpdateDTO studioName)
        {
            var foundstudio = await _studioRepository.GetIdAsync(id);

            if (foundstudio == null)
            {
                return false;
            }
            _maper.Map(studioName, foundstudio);
            return await _studioRepository.UpdateOneAsync(foundstudio);
        }
    }
}
