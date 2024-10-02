using System;
using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Publisher
    {
        public Guid PublisherId { get; set; }

        [StringLength(
            100,
            MinimumLength = 3,
            ErrorMessage = "Name must be between 3 and 100 characters"
        )]
        public string PublisherName { get; set; }

        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        public string PublisherPicturePath { get; set; }
    }
}
