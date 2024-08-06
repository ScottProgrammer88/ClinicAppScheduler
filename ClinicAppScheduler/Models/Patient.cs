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
        /// <summary>
        /// tell EF Core to make this primary key
        /// </summary>
        [Key] 
        public int PatientId { get; set; }

        /// <summary>
        /// legal first name 
        /// </summary>
        [Required]
        public string FirstName { get; set; }

        /// <summary>
        /// legal last name
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// date of birth
        /// </summary>
        [Required]
        public DateTime DateOfBirth { get; set; }

        /// <summary>
        /// primary email address
        /// </summary>
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        /// <summary>
        /// primary phone number
        /// </summary>
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// optional: brief description of reason to schedule
        /// </summary>
        public string? Description { get; set; }

        [Required]
        /// <summary>
        /// User creates password to sign in to their account
        /// </summary>
        public string PasswordHash { get; set; }
    }
}
