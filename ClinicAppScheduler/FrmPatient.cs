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

        }
    }


}
