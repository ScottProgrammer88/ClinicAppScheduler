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
    public partial class FrmHistory : Form
    {
        public FrmHistory()
        {
            InitializeComponent();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMenu menu = new FrmMenu();
            menu.Show();
            this.Hide();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAppointmentsForm appointment = new FrmAppointmentsForm();
            appointment.Show();
            this.Hide();
        }

        private void manageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmManage manage = new FrmManage();
            manage.Show();
            this.Hide();
        }
    }
}
