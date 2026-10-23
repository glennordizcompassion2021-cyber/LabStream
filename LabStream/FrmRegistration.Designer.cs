namespace LabStream
{
    partial class FrmRegistration
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblStudentNo = new System.Windows.Forms.Label();
            this.txtStudentNo = new System.Windows.Forms.TextBox();
            this.lblProgram = new System.Windows.Forms.Label();
            this.cboProgram = new System.Windows.Forms.ComboBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblMI = new System.Windows.Forms.Label();
            this.txtMI = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.cboGender = new System.Windows.Forms.ComboBox();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(18, 10);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Registration";
            // 
            // lblStudentNo
            // 
            this.lblStudentNo.AutoSize = false;
            this.lblStudentNo.Location = new System.Drawing.Point(20, 65);
            this.lblStudentNo.Name = "lblStudentNo";
            this.lblStudentNo.Size = new System.Drawing.Size(90, 23);
            this.lblStudentNo.TabIndex = 1;
            this.lblStudentNo.Text = "Student No.";
            this.lblStudentNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtStudentNo
            // 
            this.txtStudentNo.Location = new System.Drawing.Point(118, 65);
            this.txtStudentNo.Name = "txtStudentNo";
            this.txtStudentNo.Size = new System.Drawing.Size(150, 23);
            this.txtStudentNo.TabIndex = 2;
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = false;
            this.lblProgram.Location = new System.Drawing.Point(280, 65);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(75, 23);
            this.lblProgram.TabIndex = 3;
            this.lblProgram.Text = "Program";
            this.lblProgram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboProgram
            // 
            this.cboProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProgram.FormattingEnabled = true;
            this.cboProgram.Items.AddRange(new object[] {
            "BS Information Technology",
            "BS Computer Science",
            "BS Computer Engineering",
            "BS Business Administration",
            "BS Hospitality Management",
            "BS Tourism Management"});
            this.cboProgram.Location = new System.Drawing.Point(362, 65);
            this.cboProgram.Name = "cboProgram";
            this.cboProgram.Size = new System.Drawing.Size(225, 23);
            this.cboProgram.TabIndex = 4;
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = false;
            this.lblLastName.Location = new System.Drawing.Point(20, 100);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(90, 23);
            this.lblLastName.TabIndex = 5;
            this.lblLastName.Text = "Last Name";
            this.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(118, 100);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(150, 23);
            this.txtLastName.TabIndex = 6;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = false;
            this.lblFirstName.Location = new System.Drawing.Point(280, 100);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(75, 23);
            this.lblFirstName.TabIndex = 7;
            this.lblFirstName.Text = "First Name";
            this.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(362, 100);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(140, 23);
            this.txtFirstName.TabIndex = 8;
            // 
            // lblMI
            // 
            this.lblMI.AutoSize = false;
            this.lblMI.Location = new System.Drawing.Point(504, 100);
            this.lblMI.Name = "lblMI";
            this.lblMI.Size = new System.Drawing.Size(36, 23);
            this.lblMI.TabIndex = 9;
            this.lblMI.Text = "M.I.";
            this.lblMI.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMI
            // 
            this.txtMI.Location = new System.Drawing.Point(544, 100);
            this.txtMI.MaxLength = 2;
            this.txtMI.Name = "txtMI";
            this.txtMI.Size = new System.Drawing.Size(43, 23);
            this.txtMI.TabIndex = 10;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = false;
            this.lblAge.Location = new System.Drawing.Point(20, 135);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(90, 23);
            this.lblAge.TabIndex = 11;
            this.lblAge.Text = "Age";
            this.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(118, 135);
            this.txtAge.MaxLength = 3;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(60, 23);
            this.txtAge.TabIndex = 12;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = false;
            this.lblGender.Location = new System.Drawing.Point(280, 135);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(75, 23);
            this.lblGender.TabIndex = 13;
            this.lblGender.Text = "Gender:";
            this.lblGender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cboGender
            // 
            this.cboGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGender.FormattingEnabled = true;
            this.cboGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cboGender.Location = new System.Drawing.Point(362, 135);
            this.cboGender.Name = "cboGender";
            this.cboGender.Size = new System.Drawing.Size(120, 23);
            this.cboGender.TabIndex = 14;
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = false;
            this.lblBirthday.Location = new System.Drawing.Point(20, 170);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(90, 23);
            this.lblBirthday.TabIndex = 15;
            this.lblBirthday.Text = "Birthday";
            this.lblBirthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.CustomFormat = "dddd , d MMMM yyyy";
            this.dtpBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthday.Location = new System.Drawing.Point(118, 170);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(200, 23);
            this.dtpBirthday.TabIndex = 16;
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = false;
            this.lblContactNo.Location = new System.Drawing.Point(326, 170);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(90, 23);
            this.lblContactNo.TabIndex = 17;
            this.lblContactNo.Text = "Contact No.";
            this.lblContactNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Location = new System.Drawing.Point(420, 170);
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(167, 23);
            this.txtContactNo.TabIndex = 18;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(255, 225);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(100, 32);
            this.btnRegister.TabIndex = 19;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // FrmRegistration
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 280);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.cboGender);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txtMI);
            this.Controls.Add(this.lblMI);
            this.Controls.Add(this.txtFirstName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.cboProgram);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.txtStudentNo);
            this.Controls.Add(this.lblStudentNo);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmRegistration";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblStudentNo;
        private System.Windows.Forms.TextBox txtStudentNo;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.ComboBox cboProgram;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblMI;
        private System.Windows.Forms.TextBox txtMI;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.ComboBox cboGender;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.Button btnRegister;
    }
}
