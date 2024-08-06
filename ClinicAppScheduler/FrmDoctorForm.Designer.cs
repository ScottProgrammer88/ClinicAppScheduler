namespace ClinicAppScheduler
{
    partial class frmDoctor
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
            lblFullName = new Label();
            txtFullName = new TextBox();
            lblLicenseNumber = new Label();
            txtLicenseNumber = new TextBox();
            lblEmailAddress = new Label();
            txtEmailAddress = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblFullName
            // 
            lblFullName.AutoSize = true;
            lblFullName.Location = new Point(137, 60);
            lblFullName.Name = "lblFullName";
            lblFullName.Size = new Size(61, 15);
            lblFullName.TabIndex = 0;
            lblFullName.Text = "Full Name";
            // 
            // txtFullName
            // 
            txtFullName.Location = new Point(257, 60);
            txtFullName.Name = "txtFullName";
            txtFullName.Size = new Size(142, 23);
            txtFullName.TabIndex = 1;
            // 
            // lblLicenseNumber
            // 
            lblLicenseNumber.AutoSize = true;
            lblLicenseNumber.Location = new Point(137, 123);
            lblLicenseNumber.Name = "lblLicenseNumber";
            lblLicenseNumber.Size = new Size(93, 15);
            lblLicenseNumber.TabIndex = 2;
            lblLicenseNumber.Text = "License Number";
            // 
            // txtLicenseNumber
            // 
            txtLicenseNumber.Location = new Point(257, 123);
            txtLicenseNumber.Name = "txtLicenseNumber";
            txtLicenseNumber.Size = new Size(142, 23);
            txtLicenseNumber.TabIndex = 3;
            // 
            // lblEmailAddress
            // 
            lblEmailAddress.AutoSize = true;
            lblEmailAddress.Location = new Point(137, 197);
            lblEmailAddress.Name = "lblEmailAddress";
            lblEmailAddress.Size = new Size(81, 15);
            lblEmailAddress.TabIndex = 4;
            lblEmailAddress.Text = "Email Address";
            // 
            // txtEmailAddress
            // 
            txtEmailAddress.Location = new Point(257, 197);
            txtEmailAddress.Name = "txtEmailAddress";
            txtEmailAddress.Size = new Size(142, 23);
            txtEmailAddress.TabIndex = 5;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(137, 328);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(111, 40);
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmDoctor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtEmailAddress);
            Controls.Add(lblEmailAddress);
            Controls.Add(txtLicenseNumber);
            Controls.Add(lblLicenseNumber);
            Controls.Add(txtFullName);
            Controls.Add(lblFullName);
            Name = "frmDoctor";
            ShowIcon = false;
            Text = "Doctor Form";
            Load += frmDoctor_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFullName;
        private TextBox txtFullName;
        private Label lblLicenseNumber;
        private TextBox txtLicenseNumber;
        private Label lblEmailAddress;
        private TextBox txtEmailAddress;
        private Button btnSave;
    }
}