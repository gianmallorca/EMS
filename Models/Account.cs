using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class Account:IdentityUser
    {
        [Required]
        [StringLength(255, ErrorMessage = "The FirstName should have a maximum of 255 characters.")]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
