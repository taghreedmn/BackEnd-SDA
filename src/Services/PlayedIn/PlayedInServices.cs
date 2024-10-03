using AutoMapper;
using FusionTech.src.Repository;
using static FusionTech.src.DTO.PlayedInDTO;
using FusionTech.src.Entity;
using FusionTech.src.Services.PlayedIn;



namespace FusionTech.src.Services.PlayedInServices
{
    public class PlayedInServices : IPlayedInServices
    {

        protected  PlayedInRepository _playedInRepository;
        protected  IMapper _maper;

        public PlayedInServices(PlayedInRepository playedInRepository, IMapper maper)
        {
            _playedInRepository = playedInRepository;
            _maper = maper;
        }

        public async Task<ReadPlayedInDTO> CreateOneAsync(CreatePlayedInDTO createDTO)
        {
            var played = _maper.Map<CreatePlayedInDTO,Played>(createDTO);

            var playedCreated = await _playedInRepository.CreateOneAsync(played);

            return _maper.Map<Played, ReadPlayedInDTO>(playedCreated);
        }

        public async Task<List<ReadPlayedInDTO>> GetAllAsync()
        {
            var ListPlayed = await _playedInRepository.GetAllAsync();
            return _maper.Map<List<Played>, List<ReadPlayedInDTO>>(ListPlayed);
        }

        public async Task<ReadPlayedInDTO> GetIdAsync(Guid id)
        {
            var foundPlayedIn = await _playedInRepository.GetIdAsync(id);
            return _maper.Map<Played, ReadPlayedInDTO>(foundPlayedIn);
        }

        public async Task<bool> DeleteIdAsync(Guid id)
        {
            var foundPlayedIn  = await _playedInRepository.GetIdAsync(id);

            bool isDelete = await _playedInRepository.DeleteOneAsync(foundPlayedIn);
            return isDelete;
        }

        public async Task<bool> UpdateAsync(Guid id, CreatePlayedInDTO updatePlayed)
        {
            var foundplayedIn = await _playedInRepository.GetIdAsync(id);

            if (foundplayedIn  == null)
            {
                return false;
            }
            _maper.Map(updatePlayed, foundplayedIn );
            return await _playedInRepository.UpdateOneAsync(foundplayedIn);
        }
        
    }
}