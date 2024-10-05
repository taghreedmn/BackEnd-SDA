using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FusionTech.src.DTO
{
    public class VideoGameVersionDTO
    {
        public class VideoGameVersionCreateDto
        {
            public Guid VideoGameInfoId { get; set; }
            public double Price { get; set; }
        }

        public class VideoGameVersionUpdateDto
        {
            public Guid VideoGameVersionId { get; set; }
            public double? Price { get; set; }   
        }

        public class VideoGameVersionReadDto
        {
            public Guid VideoGameVersionId { get; set; }
            public Guid VideoGameInfoId { get; set; }
            public double Price { get; set; }


        }
    }
}