using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FusionTech.src.Entity;

namespace FusionTech.src.DTO
{
    public class VideoGameInfoDTO
    {

        public class VideoGameInfoCreateDto
        {
            public string? GameName { get; set; }
            public float Price { get; set; }
            public string? Description { get; set; }
            public string YearOfRelease { get; set; }
            public int TotalRating { get; set; }
            public Guid PublisherId { get; set; }
            public string? GamePicturePath { get; set; }
            public Guid CategoryId { get; set; }
        }

        public class VideoGameInfoUpdateDto
        {
            public string? GameName { get; set; }
            public float? Price { get; set; }
            public string? Description { get; set; }
            public string? YearOfRelease { get; set; }
            public int? TotalRating { get; set; }
            public Guid? PublisherId { get; set; }
            public string? GamePicturePath { get; set; }
        }

        public class VideoGameInfoReadDto
        {
            public Guid GameId { get; set; }
            public string? GameName { get; set; }
            public float Price { get; set; }
            public string? Description { get; set; }
            public string YearOfRelease { get; set; }
            public int TotalRating { get; set; }
            public Guid PublisherId { get; set; }
            public string? GamePicturePath { get; set; }
            public Category Category { get; set; }
        }
    }
}