namespace FusionTech.src.Utils
{
    public static class PersonTypeUtils
    {
        public static PersonType GetPersonType(Person person)
        {
            return person switch
            {
                SystemAdmin => SystemAdmin.PersonType,
                StoreEmployee => StoreEmployee.PersonType,
                Customer => Customer.PersonType,
                _ => Person.PersonType,
            };
        }
    }
}
