using AuthenticationAPI.Domain.Common;
using System.ComponentModel.DataAnnotations;

namespace AuthenticationAPI.Domain.Entities
{
    public abstract class User : BaseModel
    {
        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string IdNumber { get; set; }

        [Required]
        public string Gender { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string? Image { get; set; }

        [Required]
        public string Role {  get; set; }

        [Required]
        public string PhoneNumbers { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string AddressLongitude { get; set; }
        [Required]
        public string AddressLatitude { get; set; }
    }
}
