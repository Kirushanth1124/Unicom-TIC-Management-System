namespace Unicom_TIC_Management_System.Views
{
    partial class StaffDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnLoadStudents;
        private System.Windows.Forms.Button btnViewTimetable;
        private System.Windows.Forms.Button btnManageExams;
        private System.Windows.Forms.Button btnManageMarks;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.DataGridView dgvStudents;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblWelcome = new System.Windows.Forms.Label();
            this.btnLoadStudents = new System.Windows.Forms.Button();
            this.btnViewTimetable = new System.Windows.Forms.Button();
            this.btnManageExams = new System.Windows.Forms.Button();
            this.btnManageMarks = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.dgvStudents = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
            this.SuspendLayout();

            // lblWelcome
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblWelcome.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblWelcome.Location = new System.Drawing.Point(20, 20);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(120, 25);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "Welcome, ...";

            // btnLoadStudents
            this.btnLoadStudents.Location = new System.Drawing.Point(25, 65);
            this.btnLoadStudents.Name = "btnLoadStudents";
            this.btnLoadStudents.Size = new System.Drawing.Size(120, 35);
            this.btnLoadStudents.TabIndex = 1;
            this.btnLoadStudents.Text = "Load Students";
            this.btnLoadStudents.UseVisualStyleBackColor = true;
            this.btnLoadStudents.Click += new System.EventHandler(this.btnLoadStudents_Click);

            // btnViewTimetable
            this.btnViewTimetable.Location = new System.Drawing.Point(160, 65);
            this.btnViewTimetable.Name = "btnViewTimetable";
            this.btnViewTimetable.Size = new System.Drawing.Size(120, 35);
            this.btnViewTimetable.TabIndex = 2;
            this.btnViewTimetable.Text = "View Timetable";
            this.btnViewTimetable.UseVisualStyleBackColor = true;
            this.btnViewTimetable.Click += new System.EventHandler(this.btnViewTimetable_Click);

            // btnManageExams
            this.btnManageExams.Location = new System.Drawing.Point(295, 65);
            this.btnManageExams.Name = "btnManageExams";
            this.btnManageExams.Size = new System.Drawing.Size(120, 35);
            this.btnManageExams.TabIndex = 3;
            this.btnManageExams.Text = "Manage Exams";
            this.btnManageExams.UseVisualStyleBackColor = true;
            this.btnManageExams.Click += new System.EventHandler(this.btnManageExams_Click);

            // btnManageMarks
            this.btnManageMarks.Location = new System.Drawing.Point(430, 65);
            this.btnManageMarks.Name = "btnManageMarks";
            this.btnManageMarks.Size = new System.Drawing.Size(120, 35);
            this.btnManageMarks.TabIndex = 4;
            this.btnManageMarks.Text = "Manage Marks";
            this.btnManageMarks.UseVisualStyleBackColor = true;
            this.btnManageMarks.Click += new System.EventHandler(this.btnManageMarks_Click);

            // btnLogout
            this.btnLogout.Location = new System.Drawing.Point(565, 65);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 35);
            this.btnLogout.TabIndex = 5;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);

            // dgvStudents
            this.dgvStudents.AllowUserToAddRows = false;
            this.dgvStudents.AllowUserToDeleteRows = false;
            this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudents.Location = new System.Drawing.Point(25, 115);
            this.dgvStudents.MultiSelect = false;
            this.dgvStudents.Name = "dgvStudents";
            this.dgvStudents.ReadOnly = true;
            this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudents.Size = new System.Drawing.Size(660, 300);
            this.dgvStudents.TabIndex = 6;

            // StaffDashboardForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 440);
            this.Controls.Add(this.dgvStudents);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnManageMarks);
            this.Controls.Add(this.btnManageExams);
            this.Controls.Add(this.btnViewTimetable);
            this.Controls.Add(this.btnLoadStudents);
            this.Controls.Add(this.lblWelcome);
            this.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StaffDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Staff Dashboard";
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
