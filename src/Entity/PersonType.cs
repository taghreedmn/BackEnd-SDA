namespace FusionTech.src.Entity
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PersonType
    {
        Person,
        SystemAdmin,
        StoreEmployee,
        Customer,
    }
}
