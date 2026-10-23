using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace LabStream
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (!IsValid())
                return;

            string studentNo = txtStudentNo.Text.Trim();
            string mi = txtMI.Text.Trim().TrimEnd('.');

            
            string[] lines =
            {
                "Student No.:" + studentNo,
                "Full Name:" + txtLastName.Text.Trim() + ", " + txtFirstName.Text.Trim() + (mi.Length > 0 ? ", " + mi + "." : ""),
                "Program: " + cboProgram.Text,
                "Gender: " + cboGender.Text,
                "Age: " + txtAge.Text.Trim(),
                "Birthday: " + dtpBirthday.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture),
                "Contact No." + txtContactNo.Text.Trim()
            };

            
            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filePath = Path.Combine(docPath, studentNo + ".txt");

            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (string line in lines)
                {
                    outputFile.WriteLine(line);
                }
            }

            MessageBox.Show("Registration saved to:\n" + filePath, "Registration",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private bool IsValid()
        {
            string[] required = { txtStudentNo.Text, txtLastName.Text, txtFirstName.Text,
                                  txtAge.Text, txtContactNo.Text, cboProgram.Text, cboGender.Text };
            int age;

            if (required.Any(string.IsNullOrWhiteSpace))
                return Warn("Please fill in all the fields.", null);

            if (!txtStudentNo.Text.Trim().All(char.IsDigit))
                return Warn("Student No. must contain digits only.", txtStudentNo);

            if (!int.TryParse(txtAge.Text, out age) || age <= 0)
                return Warn("Age must be a valid number.", txtAge);

            return true;
        }

        private bool Warn(string message, Control focus)
        {
            MessageBox.Show(message, "Registration", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            if (focus != null) focus.Focus();
            return false;
        }
    }
}
