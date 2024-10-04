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
            public Guid CategoryId { get; set; }
            public string? CategoryName { get; set; }
        }

        // update
        public class CategoryUpdateDto
        {
            public string? CategoryName { get; set; }
        }
    }
}
