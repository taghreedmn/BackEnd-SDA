using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; // Added
using FusionTech.src.Entity;

namespace FusionTech.src.DTO
{
    public class VideoGameInfoDTO
    {
        public class VideoGameInfoCreateDto
        {
            [Required(ErrorMessage = "Game name is required.")]
            [StringLength(100, ErrorMessage = "Game name cannot exceed 100 characters.")]
            public string? GameName { get; set; }

            [Required(ErrorMessage = "Price is required.")]
            [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
            public float Price { get; set; }

            [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
            public string? Description { get; set; }

            [Required(ErrorMessage = "Year of release is required.")]
            [DataType(DataType.Date)]
            public string? YearOfRelease { get; set; }

            [Range(1, 5, ErrorMessage = "Total rating must be between 1 and 5.")]
            public int TotalRating { get; set; }
            public Guid PublisherId { get; set; }
            public string? GamePicturePath { get; set; }
            public Guid CategoryId { get; set; }
        }

        public class VideoGameInfoUpdateDto
        {
            [StringLength(100, ErrorMessage = "Game name cannot exceed 100 characters.")]
            public string? GameName { get; set; }

            [Range(0.01, double.MaxValue, ErrorMessage = "Price must be greater than zero.")]
            public float? Price { get; set; }

            [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
            public string? Description { get; set; }

            [DataType(DataType.Date)]
            public string? YearOfRelease { get; set; }

            [Range(1, 5, ErrorMessage = "Total rating must be between 1 and 5.")]
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

            public string? YearOfRelease { get; set; }

            public int TotalRating { get; set; }

            public Guid PublisherId { get; set; }

            public string? GamePicturePath { get; set; }
            public Category Category { get; set; }
        }
    }
}
