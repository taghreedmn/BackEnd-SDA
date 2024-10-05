using System.Text.Json.Serialization;

namespace FusionTech.src.Utils
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SortingTypes
    {
        ByTitle,
        // ByPrice,
        // ByDate,
        ByRating,
        None,
    }
}
