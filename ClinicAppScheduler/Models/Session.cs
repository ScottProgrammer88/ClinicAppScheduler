using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicAppScheduler.Models
{
    /// <summary>
    /// This class is to store the user that is logged in
    /// </summary>
    public static class Session
    {
        /// <summary>
        /// The patient that has logged in, their ID will be stored in userId
        /// </summary>
        public static int userId { get; set; }

        /// <summary>
        /// The patient that has logged in, their first name will be stored in userName
        /// </summary>
        public static string userName { get; set; }
    }
}
