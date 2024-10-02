using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Entity;

namespace FusionTech.src.DTO
{
    public class OrderedGamesDto
    {
        public class OrderedGamesReadDto()
        {
            public Guid Id { get; set; }
            public int OrderQuantity { get; set; }
            public VideoGameReadDto VideoGameRead { get; set; }
        }
        public class OrderedGamesCreateDto()
        {
            public Guid videoGameID { get; set; }
            public int OrderQuantity { get; set; }
        }
        public class OrderedGamesUpdateDto()
        {
            public float TotalPrice { get; set; }
        }
    }
}