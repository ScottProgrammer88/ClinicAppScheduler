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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmPatient frmPatient = new frmPatient();
            frmPatient.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var patient = Login(txtEmailAddress.Text, txtPassword.Text);
            if (patient == null)
            {
                MessageBox.Show("Invalid email or password");
            }
            else
            {
                MessageBox.Show("Login Successful");
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
            else
            {
                // BCrypt.Net.BCrypt.EnhancedVerify() checks if the password matches the password hash
                if (!BCrypt.Net.BCrypt.EnhancedVerify(password, patient.PasswordHash))
                {
                    return null;
                }
            }
            return patient;
        }

    }
}
