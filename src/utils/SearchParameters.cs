namespace FusionTech.src.Utils
{
    public class SearchParameters : PaginationOptions
    {
        public string? Title { get; set; } = "";
        public float? MinPrice { get; set; } = 0.0f;
        public float? MaxPrice { get; set; } = float.MaxValue;

        // public DateTime StartDate { get; set; } = DateTime.MinValue;
        // public DateTime EndDate { get; set; } = DateTime.MaxValue;
        public SortingTypes SortBy { get; set; } = SortingTypes.None;
        public bool Descending { get; set; } = false;

        public void IsValid()
        {
            // Check less than zero (negative price)
            // Validate MinPrice is not greater than MaxPrice
            if (MinPrice.HasValue && MaxPrice.HasValue && MinPrice.Value > MaxPrice.Value)
            {
                throw CustomException.InternalError("MinPrice cannot be greater than MaxPrice.");
            }

            // Ensure PaginationOptions are valid
            if (Limit <= 0)
            {
                throw CustomException.InternalError("Limit must be greater than zero.");
            }

            if (Offset < 0)
            {
                throw CustomException.InternalError("Offset cannot be negative.");
            }
        }
    }
}
