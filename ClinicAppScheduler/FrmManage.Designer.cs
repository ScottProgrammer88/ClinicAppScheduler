namespace ClinicAppScheduler
{
    partial class FrmManage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            menuToolStripMenuItem = new ToolStripMenuItem();
            appointmentToolStripMenuItem = new ToolStripMenuItem();
            bookToolStripMenuItem = new ToolStripMenuItem();
            manageToolStripMenuItem = new ToolStripMenuItem();
            historyToolStripMenuItem = new ToolStripMenuItem();
            ltbDoctors = new ListBox();
            rdbFemale = new RadioButton();
            rdbMale = new RadioButton();
            label1 = new Label();
            dtpAppointmentDate = new DateTimePicker();
            lblAppointmentDate = new Label();
            lblAppointmentTime = new Label();
            cmbTime = new ComboBox();
            btnCancel = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuToolStripMenuItem, appointmentToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(4, 1, 0, 1);
            menuStrip1.Size = new Size(646, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            menuToolStripMenuItem.Size = new Size(50, 22);
            menuToolStripMenuItem.Text = "Menu";
            menuToolStripMenuItem.Click += menuToolStripMenuItem_Click;
            // 
            // appointmentToolStripMenuItem
            // 
            appointmentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { bookToolStripMenuItem, manageToolStripMenuItem, historyToolStripMenuItem });
            appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            appointmentToolStripMenuItem.Size = new Size(90, 22);
            appointmentToolStripMenuItem.Text = "Appointment";
            // 
            // bookToolStripMenuItem
            // 
            bookToolStripMenuItem.Name = "bookToolStripMenuItem";
            bookToolStripMenuItem.Size = new Size(117, 22);
            bookToolStripMenuItem.Text = "Book";
            bookToolStripMenuItem.Click += bookToolStripMenuItem_Click;
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new Size(117, 22);
            manageToolStripMenuItem.Text = "Manage";
            manageToolStripMenuItem.Click += manageToolStripMenuItem_Click;
            // 
            // historyToolStripMenuItem
            // 
            historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            historyToolStripMenuItem.Size = new Size(117, 22);
            historyToolStripMenuItem.Text = "History";
            historyToolStripMenuItem.Click += historyToolStripMenuItem_Click;
            // 
            // ltbDoctors
            // 
            ltbDoctors.FormattingEnabled = true;
            ltbDoctors.ItemHeight = 15;
            ltbDoctors.Location = new Point(66, 61);
            ltbDoctors.Name = "ltbDoctors";
            ltbDoctors.Size = new Size(120, 154);
            ltbDoctors.TabIndex = 1;
            // 
            // rdbFemale
            // 
            rdbFemale.AutoSize = true;
            rdbFemale.Enabled = false;
            rdbFemale.Location = new Point(44, 247);
            rdbFemale.Name = "rdbFemale";
            rdbFemale.Size = new Size(63, 19);
            rdbFemale.TabIndex = 2;
            rdbFemale.TabStop = true;
            rdbFemale.Text = "Female";
            rdbFemale.UseVisualStyleBackColor = true;
            // 
            // rdbMale
            // 
            rdbMale.AutoSize = true;
            rdbMale.Enabled = false;
            rdbMale.Location = new Point(159, 247);
            rdbMale.Name = "rdbMale";
            rdbMale.Size = new Size(51, 19);
            rdbMale.TabIndex = 3;
            rdbMale.TabStop = true;
            rdbMale.Text = "Male";
            rdbMale.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(83, 34);
            label1.Name = "label1";
            label1.Size = new Size(86, 15);
            label1.TabIndex = 4;
            label1.Text = "Doctor Chosen";
            // 
            // dtpAppointmentDate
            // 
            dtpAppointmentDate.Enabled = false;
            dtpAppointmentDate.Location = new Point(348, 85);
            dtpAppointmentDate.Name = "dtpAppointmentDate";
            dtpAppointmentDate.Size = new Size(253, 23);
            dtpAppointmentDate.TabIndex = 10;
            // 
            // lblAppointmentDate
            // 
            lblAppointmentDate.AutoSize = true;
            lblAppointmentDate.Location = new Point(224, 91);
            lblAppointmentDate.Name = "lblAppointmentDate";
            lblAppointmentDate.Size = new Size(105, 15);
            lblAppointmentDate.TabIndex = 11;
            lblAppointmentDate.Text = "Appointment Date";
            // 
            // lblAppointmentTime
            // 
            lblAppointmentTime.AutoSize = true;
            lblAppointmentTime.Location = new Point(224, 137);
            lblAppointmentTime.Name = "lblAppointmentTime";
            lblAppointmentTime.Size = new Size(107, 15);
            lblAppointmentTime.TabIndex = 12;
            lblAppointmentTime.Text = "Appointment Time";
            // 
            // cmbTime
            // 
            cmbTime.FormattingEnabled = true;
            cmbTime.Location = new Point(348, 134);
            cmbTime.Name = "cmbTime";
            cmbTime.Size = new Size(108, 23);
            cmbTime.TabIndex = 17;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(304, 239);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(106, 34);
            btnCancel.TabIndex = 19;
            btnCancel.Text = "Cancel ";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(416, 239);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(106, 34);
            btnUpdate.TabIndex = 18;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(528, 239);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(106, 34);
            btnSave.TabIndex = 20;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // FrmManage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 316);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(btnUpdate);
            Controls.Add(cmbTime);
            Controls.Add(lblAppointmentTime);
            Controls.Add(lblAppointmentDate);
            Controls.Add(dtpAppointmentDate);
            Controls.Add(label1);
            Controls.Add(rdbMale);
            Controls.Add(rdbFemale);
            Controls.Add(ltbDoctors);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(2);
            Name = "FrmManage";
            Text = "FrmManage";
            Load += FrmManage_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuToolStripMenuItem;
        private ToolStripMenuItem appointmentToolStripMenuItem;
        private ToolStripMenuItem bookToolStripMenuItem;
        private ToolStripMenuItem manageToolStripMenuItem;
        private ToolStripMenuItem historyToolStripMenuItem;
        private ListBox ltbDoctors;
        private RadioButton rdbFemale;
        private RadioButton rdbMale;
        private Label label1;
        private DateTimePicker dtpAppointmentDate;
        private Label lblAppointmentDate;
        private Label lblAppointmentTime;
        private ComboBox cmbTime;
        private Button btnCancel;
        private Button btnUpdate;
        private Button btnSave;
    }
}