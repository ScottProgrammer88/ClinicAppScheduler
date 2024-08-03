using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicAppScheduler.Data;
using ClinicAppScheduler.Models;

namespace ClinicAppScheduler
{
    public partial class frmDoctor : Form
    {
        public frmDoctor()
        {
            InitializeComponent();
        }

        private void frmDoctor_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect doctor details from the form
            string fullName = txtFullName.Text;
            string licenseNumber = txtLicenseNumber.Text;
            string emailAddress = txtEmailAddress.Text;

            // Validate and save the doctor details to the database
            if (string.IsNullOrWhiteSpace(fullName) || string.IsNullOrWhiteSpace(licenseNumber) || string.IsNullOrWhiteSpace(emailAddress))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                // Create a new instance of the Doctor class
                Doctor newDoctor = new Doctor
                {
                    FullName = fullName,
                    LicenseNumber = licenseNumber,
                    EmailAddress = emailAddress
                };

                // Save the new doctor to the database
                using (ClinicContext context = new ClinicContext())
                {
                    context.Doctors.Add(newDoctor);
                    context.SaveChanges();
                }

                // Display a success message
                MessageBox.Show("Doctor saved successfully.");
            }
        }
    }
}
