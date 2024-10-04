using System;
using System.ComponentModel.DataAnnotations;

namespace FusionTech.src.Entity
{
    public class Publisher
    {
        public Guid PublisherId { get; set; }
        public string? PublisherName { get; set; }
        public string? Email { get; set; }
        public string? PublisherPicturePath { get; set; }
    }
}
