namespace FusionTech.src.Utils
{
    public class SearchParameters
    {
        public string? Title { get; set; } = "";
        public float? MinPrice { get; set; } = 0.0f;
        public float? MaxPrice { get; set; } = float.MaxValue;

        // public DateTime StartDate { get; set; } = DateTime.MinValue;
        // public DateTime EndDate { get; set; } = DateTime.MaxValue;
        public SortingTypes SortBy { get; set; } = SortingTypes.None;
        public bool Descending { get; set; } = false;
        public PaginationOptions PaginationOptions { get; set; } = new PaginationOptions();

        public void IsValid()
        {
            // Validate MinPrice is not greater than MaxPrice
            if (MinPrice.HasValue && MaxPrice.HasValue && MinPrice.Value > MaxPrice.Value)
            {
                throw new ArgumentException("MinPrice cannot be greater than MaxPrice.");
            }

            // Ensure PaginationOptions are valid
            if (PaginationOptions.Limit <= 0)
            {
                throw new ArgumentException("Limit must be greater than zero.");
            }

            if (PaginationOptions.Offset < 0)
            {
                throw new ArgumentException("Offset cannot be negative.");
            }
        }
    }
}
