namespace ClinicAppScheduler
{
	partial class frmPatient
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOpenDoctorForm = new Button();
            lblFirstName = new Label();
            lblLastName = new Label();
            lblDateOfBirth = new Label();
            lblEmailAddress = new Label();
            lblPhoneNumber = new Label();
            lblDescription = new Label();
            dtpDateOfBirth = new DateTimePicker();
            txtFirstName = new TextBox();
            txtLastName = new TextBox();
            txtEmailAddress = new TextBox();
            txtPhoneNumber = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // btnOpenDoctorForm
            // 
            btnOpenDoctorForm.Location = new Point(504, 473);
            btnOpenDoctorForm.Name = "btnOpenDoctorForm";
            btnOpenDoctorForm.Size = new Size(117, 47);
            btnOpenDoctorForm.TabIndex = 0;
            btnOpenDoctorForm.Text = "Open Doctor Form";
            btnOpenDoctorForm.UseVisualStyleBackColor = true;
            btnOpenDoctorForm.Click += btnOpenDoctorForm_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(91, 46);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(64, 15);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.Location = new Point(91, 104);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(63, 15);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Location = new Point(91, 170);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(75, 15);
            lblDateOfBirth.TabIndex = 3;
            lblDateOfBirth.Text = "Date Of Birth";
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(91, 235);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(81, 15);
            lblEmailAddress.TabIndex = 4;
            lblEmailAddress.Text = "Email Address";
            // 
            // lblPhoneNumber
            // 
            lblPhoneNumber.AutoSize = true;
            lblPhoneNumber.Location = new Point(91, 298);
            lblPhoneNumber.Name = "lblPhoneNumber";
            lblPhoneNumber.Size = new Size(88, 15);
            lblPhoneNumber.TabIndex = 5;
            lblPhoneNumber.Text = "Phone Number";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(91, 358);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(67, 15);
            lblDescription.TabIndex = 6;
            lblDescription.Text = "Description";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(219, 170);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(200, 23);
            dtpDateOfBirth.TabIndex = 7;
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(219, 43);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(100, 23);
            txtFirstName.TabIndex = 8;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(219, 104);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(100, 23);
            txtLastName.TabIndex = 9;
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(219, 235);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(100, 23);
            txtEmailAddress.TabIndex = 10;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(219, 298);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(100, 23);
            txtPhoneNumber.TabIndex = 11;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(219, 358);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(402, 91);
            txtDescription.TabIndex = 12;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(91, 473);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(108, 47);
            btnSave.TabIndex = 13;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // frmPatient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 553);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtEmailAddress);
            Controls.Add(txtLastName);
            Controls.Add(txtFirstName);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(lblDescription);
            Controls.Add(lblPhoneNumber);
            Controls.Add(lblEmailAddress);
            Controls.Add(lblDateOfBirth);
            Controls.Add(lblLastName);
            Controls.Add(lblFirstName);
            Controls.Add(btnOpenDoctorForm);
            Name = "frmPatient";
            Text = "Patient Form";
            Load += frmPatient_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnOpenDoctorForm;
        private Label lblFirstName;
        private Label lblLastName;
        private Label lblDateOfBirth;
        private Label lblEmailAddress;
        private Label lblPhoneNumber;
        private Label lblDescription;
        private DateTimePicker dtpDateOfBirth;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private TextBox txtEmailAddress;
        private TextBox txtPhoneNumber;
        private TextBox txtDescription;
        private Button btnSave;
    }
}
