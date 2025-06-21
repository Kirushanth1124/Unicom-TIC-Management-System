namespace Unicom_TIC_Management_System.Views
{
    partial class AdminPermissionForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;

        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;

        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;

        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;

        private System.Windows.Forms.DataGridView dgvUsers;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// Initialize UI components
        /// </summary>
        private void InitializeComponent()
        {
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            lblRole = new Label();
            cmbRole = new ComboBox();
            lblName = new Label();
            txtName = new TextBox();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dgvUsers = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Location = new Point(20, 20);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(63, 15);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Username:";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(100, 17);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(180, 23);
            txtUsername.TabIndex = 1;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Location = new Point(20, 55);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(60, 15);
            lblPassword.TabIndex = 2;
            lblPassword.Text = "Password:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(100, 52);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(180, 23);
            txtPassword.TabIndex = 3;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Location = new Point(20, 90);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(33, 15);
            lblRole.TabIndex = 4;
            lblRole.Text = "Role:";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Location = new Point(100, 87);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(180, 23);
            cmbRole.TabIndex = 5;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(20, 125);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 6;
            lblName.Text = "Name:";
            // 
            // txtName
            // 
            txtName.Location = new Point(100, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(180, 23);
            txtName.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(310, 15);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 27);
            btnAdd.TabIndex = 8;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(310, 50);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 27);
            btnUpdate.TabIndex = 9;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(310, 85);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 27);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.Location = new Point(20, 165);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(550, 300);
            dgvUsers.TabIndex = 11;
            dgvUsers.CellContentClick += dgvUsers_CellContentClick;
            // 
            // AdminPermissionForm
            // 
            ClientSize = new Size(600, 490);
            Controls.Add(lblUsername);
            Controls.Add(txtUsername);
            Controls.Add(lblPassword);
            Controls.Add(txtPassword);
            Controls.Add(lblRole);
            Controls.Add(cmbRole);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Controls.Add(btnAdd);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(dgvUsers);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "AdminPermissionForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin Permission Management";
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
    }
}
