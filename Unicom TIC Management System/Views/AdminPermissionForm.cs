using System;
using System.Windows.Forms;
using System.Collections.Generic;
using Unicom_TIC_Management_System.Controllers;
using Unicom_TIC_Management_System.Modals;

namespace Unicom_TIC_Management_System.Views
{
    public partial class AdminPermissionForm : Form
    {
        private AdminPermissionController controller = new AdminPermissionController();
        private int selectedUserId = -1;

        public AdminPermissionForm()
        {
            InitializeComponent();

            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.MultiSelect = false;
            dgvUsers.ReadOnly = true;

            dgvUsers.CellClick += DgvUsers_CellClick;
            dgvUsers.SelectionChanged += DgvUsers_SelectionChanged;
            txtSearch.TextChanged += TxtSearch_TextChanged;

            LoadRoles();
            LoadUsers();
        }

        private void LoadRoles()
        {
            cmbRole.Items.Clear();
            cmbRole.Items.AddRange(new string[] { "Admin", "Lecturer", "Staff", "Student" });
            cmbRole.SelectedIndex = 0;
        }

        private void LoadUsers()
        {
            try
            {
                var users = controller.GetAllUsers();
                dgvUsers.DataSource = null;
                dgvUsers.DataSource = users;

                FormatGridHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load users: " + ex.Message);
            }
        }

        private void FormatGridHeaders()
        {
            if (dgvUsers.Columns["UserID"] != null)
                dgvUsers.Columns["UserID"].HeaderText = "User ID";
            if (dgvUsers.Columns["Username"] != null)
                dgvUsers.Columns["Username"].HeaderText = "Username";
            if (dgvUsers.Columns["Password"] != null)
                dgvUsers.Columns["Password"].HeaderText = "Password";
            if (dgvUsers.Columns["Role"] != null)
                dgvUsers.Columns["Role"].HeaderText = "Role";
            if (dgvUsers.Columns["Name"] != null)
                dgvUsers.Columns["Name"].HeaderText = "Name";
        }

        private void ClearForm()
        {
            txtName.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            cmbRole.SelectedIndex = 0;
            selectedUserId = -1;
            dgvUsers.ClearSelection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            AppUser user = new AppUser
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString(),
                Name = txtName.Text.Trim()
            };

            try
            {
                controller.AddUser(user);
                MessageBox.Show("User added successfully.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add user: " + ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            if (!ValidateInputs()) return;

            AppUser user = new AppUser
            {
                UserID = selectedUserId,
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString(),
                Name = txtName.Text.Trim()
            };

            try
            {
                controller.UpdateUser(user);
                MessageBox.Show("User updated successfully.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update user: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    controller.DeleteUser(selectedUserId);
                    MessageBox.Show("User deleted successfully.");
                    LoadUsers();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete user: " + ex.Message);
                }
            }
        }

        private void DgvUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                LoadUserDetailsFromRow(dgvUsers.Rows[e.RowIndex]);
            }
        }

        private void DgvUsers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                LoadUserDetailsFromRow(dgvUsers.SelectedRows[0]);
            }
        }

        private void LoadUserDetailsFromRow(DataGridViewRow row)
        {
            if (row == null) return;

            try
            {
                selectedUserId = Convert.ToInt32(row.Cells["UserID"].Value);
                txtUsername.Text = row.Cells["Username"].Value?.ToString() ?? "";
                txtPassword.Text = row.Cells["Password"].Value?.ToString() ?? "";
                txtName.Text = row.Cells["Name"].Value?.ToString() ?? "";
                cmbRole.SelectedItem = row.Cells["Role"].Value?.ToString() ?? cmbRole.Items[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) ||
                string.IsNullOrWhiteSpace(txtPassword.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return false;
            }
            if (cmbRole.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a role.");
                return false;
            }
            return true;
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.ToLower();
            var filteredUsers = controller.SearchUsers(searchTerm);

            dgvUsers.DataSource = null;
            dgvUsers.DataSource = filteredUsers;

            FormatGridHeaders();
        }

        private void dgvUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                LoadUserDetailsFromRow(dgvUsers.SelectedRows[0]);
            }
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;

            AppUser user = new AppUser
            {
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString(),
                Name = txtName.Text.Trim()
            };

            try
            {
                controller.AddUser(user);
                MessageBox.Show("User added successfully.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to add user: " + ex.Message);
            }
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to update.");
                return;
            }

            if (!ValidateInputs()) return;

            AppUser user = new AppUser
            {
                UserID = selectedUserId,
                Username = txtUsername.Text.Trim(),
                Password = txtPassword.Text.Trim(),
                Role = cmbRole.SelectedItem.ToString(),
                Name = txtName.Text.Trim()
            };

            try
            {
                controller.UpdateUser(user);
                MessageBox.Show("User updated successfully.");
                LoadUsers();
                ClearForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to update user: " + ex.Message);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            if (selectedUserId == -1)
            {
                MessageBox.Show("Please select a user to delete.");
                return;
            }

            var confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    controller.DeleteUser(selectedUserId);
                    MessageBox.Show("User deleted successfully.");
                    LoadUsers();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to delete user: " + ex.Message);
                }
            }
        }

        private void dgvUsers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

            if (dgvUsers.SelectedRows.Count > 0)
            {
                LoadUserDetailsFromRow(dgvUsers.SelectedRows[0]);
            }
        }

        public object GetAllUsers()
        {
            throw new NotImplementedException();
        }
    }
}
