using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppScheduler.Models
{
    public class Patient
    {
        // tell EF Core to make this primary key
        [Key] 
        public int PatientId { get; set; }

        // legal first name 
        [Required]
        public string FirstName { get; set; }

        // legal last name
        [Required]
        public string LastName { get; set; }

        // date of birth
        [Required]
        public DateTime DateOfBirth { get; set; }

        // primary email address
        [Required]
        public string EmailAddress { get; set; }

        // primary phone number
        [Required]
        public string PhoneNumber { get; set; }

        // optional
        // brief description of reason to schedule
        public string? Description { get; set; }
    }
}
