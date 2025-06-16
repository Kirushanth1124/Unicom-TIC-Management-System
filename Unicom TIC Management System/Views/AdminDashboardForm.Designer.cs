namespace Unicom_TIC_Management_System.Views
{
    partial class AdminDashboardForm
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
            btnLogout = new Button();
            btnManageCourses = new Button();
            btnManageLecturers = new Button();
            btnManageStudents = new Button();
            btnManageTimeTable = new Button();
            btnManageExam = new Button();
            btnManageMarks = new Button();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.LightGray;
            btnLogout.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(654, 399);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(125, 48);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageCourses
            // 
            btnManageCourses.BackColor = Color.LightGray;
            btnManageCourses.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageCourses.Location = new Point(68, 179);
            btnManageCourses.Name = "btnManageCourses";
            btnManageCourses.Size = new Size(160, 35);
            btnManageCourses.TabIndex = 1;
            btnManageCourses.Text = "Manage Course";
            btnManageCourses.UseVisualStyleBackColor = false;
            btnManageCourses.Click += btnManageCourses_Click;
            // 
            // btnManageLecturers
            // 
            btnManageLecturers.BackColor = Color.LightGray;
            btnManageLecturers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageLecturers.Location = new Point(68, 252);
            btnManageLecturers.Name = "btnManageLecturers";
            btnManageLecturers.Size = new Size(160, 31);
            btnManageLecturers.TabIndex = 2;
            btnManageLecturers.Text = "Manage Lecturer";
            btnManageLecturers.UseVisualStyleBackColor = false;
            btnManageLecturers.Click += btnManageLecturers_Click;
            // 
            // btnManageStudents
            // 
            btnManageStudents.BackColor = Color.LightGray;
            btnManageStudents.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageStudents.Location = new Point(68, 36);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(160, 33);
            btnManageStudents.TabIndex = 3;
            btnManageStudents.Text = "Manage Student";
            btnManageStudents.UseVisualStyleBackColor = false;
            btnManageStudents.Click += btnManageStudents_Click;
            // 
            // btnManageTimeTable
            // 
            btnManageTimeTable.BackColor = Color.LightGray;
            btnManageTimeTable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageTimeTable.Location = new Point(68, 389);
            btnManageTimeTable.Name = "btnManageTimeTable";
            btnManageTimeTable.Size = new Size(160, 33);
            btnManageTimeTable.TabIndex = 4;
            btnManageTimeTable.Text = "Manage Timetable";
            btnManageTimeTable.UseVisualStyleBackColor = false;
            btnManageTimeTable.Click += btnManageTimeTable_Click;
            // 
            // btnManageExam
            // 
            btnManageExam.BackColor = Color.LightGray;
            btnManageExam.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageExam.Location = new Point(68, 105);
            btnManageExam.Name = "btnManageExam";
            btnManageExam.Size = new Size(160, 35);
            btnManageExam.TabIndex = 5;
            btnManageExam.Text = "Manage Exam";
            btnManageExam.UseVisualStyleBackColor = false;
            btnManageExam.Click += button6_Click;
            // 
            // btnManageMarks
            // 
            btnManageMarks.BackColor = Color.LightGray;
            btnManageMarks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnManageMarks.Location = new Point(68, 318);
            btnManageMarks.Name = "btnManageMarks";
            btnManageMarks.Size = new Size(160, 34);
            btnManageMarks.TabIndex = 6;
            btnManageMarks.Text = "Manage Marks";
            btnManageMarks.UseVisualStyleBackColor = false;
            btnManageMarks.Click += btnManageMarks_Click;
            // 
            // AdminDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnManageMarks);
            Controls.Add(btnManageExam);
            Controls.Add(btnManageTimeTable);
            Controls.Add(btnManageStudents);
            Controls.Add(btnManageLecturers);
            Controls.Add(btnManageCourses);
            Controls.Add(btnLogout);
            ForeColor = Color.Maroon;
            Name = "AdminDashboardForm";
            Text = "AdminDashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogout;
        private Button btnManageCourses;
        private Button btnManageLecturers;
        private Button btnManageStudents;
        private Button btnManageTimeTable;
        private Button btnManageExam;
        private Button btnManageMarks;
    }
}