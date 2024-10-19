namespace FusionTech.src.Services.Console
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

        public async Task<ReadConsoleDTO> CreateOneAsync(CreateConsoleDTO createDTO)
        {
            var console = _maper.Map<CreateConsoleDTO, GameConsole>(createDTO);

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
            if (foundconsole == null)
            {
                throw CustomException.NotFound("Console not found.");
            }
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

            if (foundconsole == null)
            {
                throw CustomException.NotFound("Console not found.");
            }
            _maper.Map(ConsoleName, foundconsole);
            return await _consoleRepository.UpdateOneAsync(foundconsole);
        }
    }
}
