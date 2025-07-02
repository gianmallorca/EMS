using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace EMS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        [Required]
        public string FullName { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Position { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public DateTime DateHired { get; set; }
        public bool IsActive { get; set; } 


    }
}
