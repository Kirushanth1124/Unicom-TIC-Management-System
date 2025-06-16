namespace Unicom_TIC_Management_System.Views
{
    partial class StaffDashboardForm
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
            lblWelcome = new Label();
            dgvStudents = new DataGridView();
            btnLoadStudents = new Button();
            btnViewTimetable = new Button();
            btnManageExams = new Button();
            btnManageMarks = new Button();
            btnLogout = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvStudents).BeginInit();
            SuspendLayout();
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(70, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(38, 15);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "label1";
            // 
            // dgvStudents
            // 
            dgvStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStudents.Location = new Point(425, 214);
            dgvStudents.Name = "dgvStudents";
            dgvStudents.Size = new Size(240, 150);
            dgvStudents.TabIndex = 1;
            // 
            // btnLoadStudents
            // 
            btnLoadStudents.Location = new Point(33, 88);
            btnLoadStudents.Name = "btnLoadStudents";
            btnLoadStudents.Size = new Size(130, 23);
            btnLoadStudents.TabIndex = 2;
            btnLoadStudents.Text = "Load Students";
            btnLoadStudents.UseVisualStyleBackColor = true;
            btnLoadStudents.Click += btnLoadStudents_Click_1;
            // 
            // btnViewTimetable
            // 
            btnViewTimetable.Location = new Point(33, 142);
            btnViewTimetable.Name = "btnViewTimetable";
            btnViewTimetable.Size = new Size(130, 23);
            btnViewTimetable.TabIndex = 3;
            btnViewTimetable.Text = "View Timetable";
            btnViewTimetable.UseVisualStyleBackColor = true;
            btnViewTimetable.Click += btnViewTimetable_Click_1;
            // 
            // btnManageExams
            // 
            btnManageExams.Location = new Point(33, 197);
            btnManageExams.Name = "btnManageExams";
            btnManageExams.Size = new Size(130, 23);
            btnManageExams.TabIndex = 4;
            btnManageExams.Text = "Manage Exams";
            btnManageExams.UseVisualStyleBackColor = true;
            btnManageExams.Click += btnManageExams_Click_1;
            // 
            // btnManageMarks
            // 
            btnManageMarks.Location = new Point(33, 252);
            btnManageMarks.Name = "btnManageMarks";
            btnManageMarks.Size = new Size(130, 23);
            btnManageMarks.TabIndex = 5;
            btnManageMarks.Text = "Manage Marks";
            btnManageMarks.UseVisualStyleBackColor = true;
            btnManageMarks.Click += btnManageMarks_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(33, 415);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(130, 23);
            btnLogout.TabIndex = 6;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // StaffDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnManageMarks);
            Controls.Add(btnManageExams);
            Controls.Add(btnViewTimetable);
            Controls.Add(btnLoadStudents);
            Controls.Add(dgvStudents);
            Controls.Add(lblWelcome);
            Name = "StaffDashboardForm";
            Text = "StaffDashboardForm";
            ((System.ComponentModel.ISupportInitialize)dgvStudents).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblWelcome;
        private DataGridView dgvStudents;
        private Button btnLoadStudents;
        private Button btnViewTimetable;
        private Button btnManageExams;
        private Button btnManageMarks;
        private Button btnLogout;
    }
}