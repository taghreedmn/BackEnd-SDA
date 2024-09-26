using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;
using FusionTech.src.utils;

namespace FusionTech.src.Entity
{
    public abstract class Person
    {
        private const int SYSTEM_ADMIN_START_INDEX = 0;

        // const int SYSTEM_ADMIN_END_INDEX = STORE_EMPLOYEE_START_INDEX - 1;
        private const int STORE_EMPLOYEE_START_INDEX = 1000;

        // const int STORE_EMPLOYEE_END_INDEX = CUSTOMER_START_INDEX - 1;
        private const int CUSTOMER_START_INDEX = 100000;

        // const int CUSTOMER_END_INDEX = int.MaxValue;
        private static readonly Dictionary<PersonType, PersonTypeMetadata> _PersonTypeInfo =
            new Dictionary<PersonType, PersonTypeMetadata>
            {
                {
                    PersonType.System_Admin,
                    new PersonTypeMetadata(SYSTEM_ADMIN_START_INDEX, STORE_EMPLOYEE_START_INDEX - 1)
                },
                {
                    PersonType.Store_Employee,
                    new PersonTypeMetadata(STORE_EMPLOYEE_START_INDEX, CUSTOMER_START_INDEX - 1)
                },
                { PersonType.Customer, new PersonTypeMetadata(CUSTOMER_START_INDEX, int.MaxValue) },
            };

        public PersonType Type { get; private set; }

        private int _id;
        public int PersonId
        {
            get => _id;
            private set
            {
                // Check Id limit to avoid wrong entity creation
                if (_PersonTypeInfo[Type].Counter >= _PersonTypeInfo[Type].LimitId)
                {
                    throw new InvalidOperationException("ID limit reached for " + Type);
                }
                // Increment and assign the ID counter
                PersonTypeMetadata typeMetadata = _PersonTypeInfo[Type];
                _id = ++typeMetadata.Counter;
                _PersonTypeInfo[Type] = typeMetadata;
            }
        }

        // Name must not be null, and should be at least 3 characters
        [Required(ErrorMessage = "Name is required")]
        [StringLength(
            100,
            MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 100 characters"
        )]
        public string PersonName { get; private set; }

        // Email must be valid and non-empty
        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string PersonEmail { get; private set; }

        private string _personPassword;
        public string PersonPassword
        {
            get => _personPassword;
            private set
            {
                // var passwordPattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&-_])[A-Za-z\d@$!%*?&-_]{8,}$";
                // if (Regex.IsMatch(value, passwordPattern))

                PasswordUtils.HashPassword(value, out _personPassword, out _salt);
            }
        }

        // Phone number must match a specific format
        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage = "Invalid phone number")]
        public string PersonPhone { get; private set; }

        public string ProfilePicturePath { get; set; }

        private byte[] _salt;

        protected Person(
            PersonType type,
            string name,
            string email,
            string password,
            string phone,
            string profilePicturePath
        )
        {
            Type = type;
            PersonName = name;
            PersonEmail = email;
            PersonPassword = password;
            PersonPhone = phone;
            ProfilePicturePath = profilePicturePath;
            PersonId = -1; // Assign the ID by calling the setter
        }

        public bool trySignIn(string enteredPassword) =>
            PasswordUtils.isPasswordEqual(enteredPassword, _personPassword, _salt);
    }

    internal struct PersonTypeMetadata
    {
        public int BaseId { get; }
        public int LimitId { get; }
        public int Counter { get; set; }

        public PersonTypeMetadata(int baseId, int limitId)
        {
            BaseId = baseId;
            LimitId = limitId;
            Counter = baseId;
        }
    }

    public enum PersonType
    {
        System_Admin,
        Store_Employee,
        Customer,
    }
}
