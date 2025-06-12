using System;
using System.Windows.Forms;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class LoginForm : Form
    {
        private readonly LoginController loginController = new LoginController();

        public LoginForm()
        {
            InitializeComponent();
            comboBoxRole.SelectedIndex = 0; 
        }

        private void btnLogin_Click(object sender, EventArgs e)
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

                // Example of role redirection
                this.Hide();
                Form dashboard = null;

                switch (user.Role.ToLower())
                {
                    case "admin":
                        dashboard = new AdminDashboardForm();
                        break;
                    case "staff":
                        dashboard = new StaffDashboardForm();
                        break;
                    case "student":
                        dashboard = new StudentDashboardForm();
                        break;
                    case "lecturer":
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
}
