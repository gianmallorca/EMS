using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class AccountUserView
    {
        [ValidateNever]
        public string Id { get; set; }


        [Required]
        [EmailAddress]
        [Remote(action: "IsEmailInUse", "AppUsers")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string FullName { get; set; }
    }
}
