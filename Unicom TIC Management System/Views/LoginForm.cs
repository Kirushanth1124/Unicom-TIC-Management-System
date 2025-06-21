using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controllers;

namespace Unicom_TIC_Management_System.Views
{
    public partial class LoginForm : Form
    {
        private readonly LoginController loginController = new LoginController();

        public LoginForm()
        {
            InitializeComponent();
            this.BackgroundImage = Image.FromFile("Z:\\C# Programming\\Unicom TIC Management System\\B.JPG");
            this.BackgroundImageLayout = ImageLayout.Stretch;

            comboBoxRole.Items.Clear();
            comboBoxRole.Items.Add("Admin");
            comboBoxRole.Items.Add("Staff");
            comboBoxRole.Items.Add("Student");
            comboBoxRole.Items.Add("Lecturer");

            if (comboBoxRole.Items.Count > 0)
            {
                comboBoxRole.SelectedIndex = 0;
            }
        }



        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            {
                string username = txtUsername.Text.Trim();
                string password = txtPassword.Text.Trim();
                string role = comboBoxRole.SelectedItem.ToString();

                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Please enter both username and password.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var user = loginController.Login(username, password, role);
                if (user != null)
                {
                    MessageBox.Show($"Welcome, {user.Role}!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    Form dashboard = null;

                    switch (user.Role)
                    {
                        case "Admin":
                            dashboard = new AdminDashboardForm();
                            break;
                        case "Staff":
                            dashboard = new StaffDashboardForm();
                            break;
                        case "Student":
                            dashboard = new StudentDashboardForm();
                            break;
                        case "Lecturer":
                            dashboard = new LecturerDashboardForm();
                            break;
                        default:
                            MessageBox.Show("Invalid role configured.");
                            return;
                    }

                    dashboard.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid username, password, or role.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridViewUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBoxRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
