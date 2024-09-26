using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FusionTech.src.DTO
{
    public class CategoryDTO
    {
        public class CategoryCreateDto
        {
            public string? CategoryName { get; set; }
        }
        // read data = get data
        public class CategoryReadDto
        {
            public Guid Id { get; set; }
            public string? CategoryName { get; set; }
        }
        // update
        public class CategoryUpdateDto
        {
            public string? CategoryName { get; set; }

        }

    }
}