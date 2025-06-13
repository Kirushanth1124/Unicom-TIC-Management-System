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
            btnLogout.Location = new Point(704, 399);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnManageCourses
            // 
            btnManageCourses.Location = new Point(310, 179);
            btnManageCourses.Name = "btnManageCourses";
            btnManageCourses.Size = new Size(109, 23);
            btnManageCourses.TabIndex = 1;
            btnManageCourses.Text = "Manage Course";
            btnManageCourses.UseVisualStyleBackColor = true;
            btnManageCourses.Click += btnManageCourses_Click;
            // 
            // btnManageLecturers
            // 
            btnManageLecturers.Location = new Point(437, 179);
            btnManageLecturers.Name = "btnManageLecturers";
            btnManageLecturers.Size = new Size(140, 23);
            btnManageLecturers.TabIndex = 2;
            btnManageLecturers.Text = "Manage Lecturer";
            btnManageLecturers.UseVisualStyleBackColor = true;
            btnManageLecturers.Click += btnManageLecturers_Click;
            // 
            // btnManageStudents
            // 
            btnManageStudents.Location = new Point(169, 179);
            btnManageStudents.Name = "btnManageStudents";
            btnManageStudents.Size = new Size(113, 23);
            btnManageStudents.TabIndex = 3;
            btnManageStudents.Text = "Manage Student";
            btnManageStudents.UseVisualStyleBackColor = true;
            btnManageStudents.Click += btnManageStudents_Click;
            // 
            // btnManageTimeTable
            // 
            btnManageTimeTable.Location = new Point(400, 231);
            btnManageTimeTable.Name = "btnManageTimeTable";
            btnManageTimeTable.Size = new Size(140, 23);
            btnManageTimeTable.TabIndex = 4;
            btnManageTimeTable.Text = "Manage Timetable";
            btnManageTimeTable.UseVisualStyleBackColor = true;
            btnManageTimeTable.Click += btnManageTimeTable_Click;
            // 
            // btnManageExam
            // 
            btnManageExam.Location = new Point(202, 231);
            btnManageExam.Name = "btnManageExam";
            btnManageExam.Size = new Size(140, 23);
            btnManageExam.TabIndex = 5;
            btnManageExam.Text = "Manage Exam";
            btnManageExam.UseVisualStyleBackColor = true;
            btnManageExam.Click += button6_Click;
            // 
            // btnManageMarks
            // 
            btnManageMarks.Location = new Point(310, 287);
            btnManageMarks.Name = "btnManageMarks";
            btnManageMarks.Size = new Size(140, 23);
            btnManageMarks.TabIndex = 6;
            btnManageMarks.Text = "Manage Marks";
            btnManageMarks.UseVisualStyleBackColor = true;
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