using System.Collections.Generic;

namespace FusionTech.src.Entity
{
    public class GameConsole
    {
        public Guid GameConsoleId { get; set; }
        public string ConsoleName { get; set; }
        public ICollection<VideoGameVersion> VideoGames { get; set; }
        public string? ConsoleName { get; set; }

    }
}
