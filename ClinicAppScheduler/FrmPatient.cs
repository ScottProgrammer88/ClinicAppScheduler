using ClinicAppScheduler.Data;
using ClinicAppScheduler.Models;

namespace ClinicAppScheduler
{
    public partial class frmPatient : Form
    {
        public frmPatient()
        {
            InitializeComponent();
        }

        private void btnOpenDoctorForm_Click(object sender, EventArgs e)
        {
            // Create an instance of the frmDoctor form, this creates a new object. 
            frmDoctor doctorForm = new frmDoctor();

            // Display the form as a modal dialog box
            doctorForm.ShowDialog();
        }

        private void frmPatient_Load(object sender, EventArgs e)
        {
            // Sets range for date time picker 
            // goes back to 1900-current date
            dtpDateOfBirth.MinDate = new DateTime(1900, 1, 1);
            dtpDateOfBirth.MaxDate = DateTime.Today;
        }

        /// <summary>
        /// Collects patient details from the form, validates the input, and saves
        /// the new patient information to the database and displays a success message.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            // Collect patient details from the form
            string firstName = txtFirstName.Text; // Get the text from the txtFirstName textbox
            string lastName = txtLastName.Text;
            DateTime dateOfBirth = dtpDateOfBirth.Value; // Get the value from the dtpDateOfBirth DateTimePicker
            string emailAddress = txtEmailAddress.Text;
            string phoneNumber = txtPhoneNumber.Text;
            string description = txtDescription.Text;
            string password = HashedPassword(txtPassword.Text);

            // Validate and save the patient details to the database
            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) ||
                    string.IsNullOrWhiteSpace(emailAddress) || string.IsNullOrWhiteSpace(phoneNumber) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please fill in all required fields.");
            }
            else
            {
                // Create a new instance of the Patient class
                Patient newPatient = new Patient
                {
                    FirstName = firstName,
                    LastName = lastName,
                    DateOfBirth = dateOfBirth,
                    EmailAddress = emailAddress,
                    PhoneNumber = phoneNumber,
                    Description = description,
                    PasswordHash = password
                };

                // Add the new patient to the database
                using (var context = new ClinicContext()) // Create a new instance of the ClinicContext
                {
                    context.Patients.Add(newPatient); // Add the new patient to the Patients DbSet
                    context.SaveChanges(); // Save the changes to the database
                }

                MessageBox.Show("Patient saved successfully!");
                FrmLogin login = new FrmLogin();
                login.Show();
                this.Hide();
            }

        }

        /// <summary>
        /// takes users password entered and hashes it to prevent attackers from 
        /// hacking into their accounts
        /// </summary>
        /// <param name="password">user creates their own password to create account</param>
        /// <returns>hashed password</returns>
        private string HashedPassword(string password)
        {
            // To use BCrypt.Net must install BCrypt.Net-Next
            // BCrypt.Net.BCrypt.EnhancedHashPassword() to create hashed password
            string passwordHash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
            return passwordHash;
        }

        private void btnOpenAppointmentsForm_Click(object sender, EventArgs e)
        {
            // Create an instance of the FrmAppointmentsForm form
            FrmAppointmentsForm appointmentsForm = new FrmAppointmentsForm();

            // use ShowDialog() to display the form as a modal dialog box
            appointmentsForm.ShowDialog(); 
        }
    }


}
