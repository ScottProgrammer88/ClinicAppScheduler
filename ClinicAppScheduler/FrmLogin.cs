using ClinicAppScheduler.Data;
using ClinicAppScheduler.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicAppScheduler
{
    /// <summary>
    /// This form is for when the user logs in using their email and password.
    /// If successful user will be logged into their account using their ID to keep 
    /// track of who is signed in. If not successful user receives invalid message 
    /// </summary>
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// This button sends user to the patient form to create an account
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SignUpButton(object sender, EventArgs e)
        {
            frmPatient frmPatient = new frmPatient();
            frmPatient.Show();
            this.Hide();
        }

        /// <summary>
        /// This method uses a method called Login to send the email and 
        /// password the user put in to check for validation.
        /// If successful user receives success message and is sent to the Menu form.
        /// If not user receives invalid message;
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton(object sender, EventArgs e)
        {
            var patient = Login(txtEmailAddress.Text, txtPassword.Text);
            if (patient == null)
            {
                MessageBox.Show("Invalid email or password");
            }
            else
            {
                MessageBox.Show("Login Successful");
                // Set session details
                LoginUser(patient.PatientId);
                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();

            }
        }

        /// <summary>
        /// Method takes two parameters emailAddress and password.
        /// It uses a query to find if the emailAddress is in the database.
        /// If the emailAddress is found, the password is then checked
        /// if it matches the hashed password in the database.
        /// </summary>
        /// <param name="emailAddress">users inputs emailAddress</param>
        /// <param name="password">user inputs password</param>
        /// <returns>If both matches it will return patient</returns>
        private Patient Login(string emailAddress, string password)
        {
            using ClinicContext dbContext = new();
            // query: finds if the emailAddress inputed matches any in the database
            var patient = dbContext.Patients.SingleOrDefault(p => p.EmailAddress.Equals(emailAddress));
            // if emailAddress is not found it returns null 
            if (patient == null)
            {
                return null;
            }
                
            // BCrypt.Net.BCrypt.EnhancedVerify() checks if the password matches the password hash
            if (BCrypt.Net.BCrypt.EnhancedVerify(password, patient.PasswordHash))
            {
                // After validation store PatientId to Session.userId to keep track
                // of which Patient is logged in. Same for the Patients first name.
                Session.userId = patient.PatientId;
                Session.userName = patient.FirstName;

                return patient;
            }
            return null;
        }

        
        /// <summary>
        /// Method to set session details
        /// </summary>
        /// <param name="patientId"></param>
        private void LoginUser(int patientId)
        {
            using (var context = new ClinicContext())
            {
                var patient = context.Patients.FirstOrDefault(p => p.PatientId == patientId);
                if (patient != null)
                {
                    Session.userId = patient.PatientId;
                    Session.userName = patient.FirstName;
                }
            }
        }
    }
}
