using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppScheduler.Models
{
    /// <summary>
    /// This is the Doctor table where the doctors personal 
    /// information will be saved 
    /// </summary>
    public class Doctor
    {
        // tell EF Core to make this primary key
        [Key]
        public int DoctorId { get; set; }

        // legal first and last name
        [Required]
        public string FullName { get; set; }

        // medical license number
        [Required]
        public string LicenseNumber { get; set; }

        // work email address
        [Required]
        [EmailAddress]
        public string EmailAddress { get; set; }

        // Either female or male 
        [Required]
        public char Gender { get; set; }
    }
}
