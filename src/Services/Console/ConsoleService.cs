using AutoMapper;
using FusionTech.src.Entity;
using FusionTech.src.Repository;
using sda_3_online_Backend_Teamwork.src.Repository;
using static sda_3_online_Backend_Teamwork.src.DTO.ConsoleDTO;

namespace FusionTech.Service.Console
{
    public class ConsoleService : IConsoleService
    {
        protected readonly ConsoleRepository _consoleRepository;
        protected readonly IMapper _maper;

        public ConsoleService(ConsoleRepository consoleRepository, IMapper maper)
        {
            _consoleRepository = consoleRepository;
            _maper = maper;
        }

        public async Task<ReadConsoleDTO> CreateOneAsync(CreatConsoleDTO createDTO)
        {
            var console = _maper.Map<CreatConsoleDTO, GameConsole>(createDTO);

            var consoleCreated = await _consoleRepository.CreateOneAsync(console);

            return _maper.Map<GameConsole, ReadConsoleDTO>(consoleCreated);
        }

        public async Task<List<ReadConsoleDTO>> GetAllAsync()
        {
            var Listconsole = await _consoleRepository.GetAllAsync();
            return _maper.Map<List<GameConsole>, List<ReadConsoleDTO>>(Listconsole);
        }

        public async Task<ReadConsoleDTO> GetIdAsync(Guid id)
        {
            var foundconsole = await _consoleRepository.GetIdAsync(id);
            return _maper.Map<GameConsole, ReadConsoleDTO>(foundconsole);
        }

        public async Task<bool> DeleteIdAsync(Guid id)
        {
            var foundconsole = await _consoleRepository.GetIdAsync(id);

            bool isDelete = await _consoleRepository.DeleteOneAsync(foundconsole);
            return isDelete;
        }

        public async Task<bool> UpdateAsync(Guid id, UpdateConsoleDTO ConsoleName)
        {
            var foundconsole = await _consoleRepository.GetIdAsync(id);
            var UpdateConsole = await _consoleRepository.UpdateOneAsync(foundconsole);
            if (foundconsole == null)
            {
                return false;
            }
            _maper.Map(UpdateConsole, foundconsole);
            return await _consoleRepository.UpdateOneAsync(foundconsole);
        }
    }
}
