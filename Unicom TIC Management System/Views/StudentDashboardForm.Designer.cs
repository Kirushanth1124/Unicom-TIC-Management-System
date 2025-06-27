namespace Unicom_TIC_Management_System.Views
{
    partial class StudentDashboardForm
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
            btnViewMarks = new Button();
            btnViewTimetable = new Button();
            btnLogout = new Button();
            dgvData = new DataGridView();
            btnViewcourse = new Button();
            btnExamView = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvData).BeginInit();
            SuspendLayout();
            // 
            // btnViewMarks
            // 
            btnViewMarks.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewMarks.Location = new Point(28, 34);
            btnViewMarks.Name = "btnViewMarks";
            btnViewMarks.Size = new Size(141, 32);
            btnViewMarks.TabIndex = 1;
            btnViewMarks.Text = "View Marks";
            btnViewMarks.UseVisualStyleBackColor = true;
            btnViewMarks.Click += btnViewMarks_Click_1;
            // 
            // btnViewTimetable
            // 
            btnViewTimetable.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewTimetable.Location = new Point(28, 87);
            btnViewTimetable.Name = "btnViewTimetable";
            btnViewTimetable.Size = new Size(141, 32);
            btnViewTimetable.TabIndex = 2;
            btnViewTimetable.Text = "View Timetable";
            btnViewTimetable.UseVisualStyleBackColor = true;
            btnViewTimetable.Click += btnViewTimetable_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(680, 396);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(90, 42);
            btnLogout.TabIndex = 3;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // dgvData
            // 
            dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvData.Location = new Point(12, 240);
            dgvData.Name = "dgvData";
            dgvData.Size = new Size(389, 198);
            dgvData.TabIndex = 4;
            dgvData.CellContentClick += dgvData_CellContentClick;
            // 
            // btnViewcourse
            // 
            btnViewcourse.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnViewcourse.Location = new Point(28, 146);
            btnViewcourse.Name = "btnViewcourse";
            btnViewcourse.Size = new Size(141, 29);
            btnViewcourse.TabIndex = 5;
            btnViewcourse.Text = "View Course";
            btnViewcourse.UseVisualStyleBackColor = true;
            btnViewcourse.Click += btnViewcourse_Click;
            // 
            // btnExamView
            // 
            btnExamView.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExamView.Location = new Point(28, 196);
            btnExamView.Name = "btnExamView";
            btnExamView.Size = new Size(141, 29);
            btnExamView.TabIndex = 6;
            btnExamView.Text = "View Exam";
            btnExamView.UseVisualStyleBackColor = true;
            btnExamView.Click += button1_Click;
            // 
            // StudentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExamView);
            Controls.Add(btnViewcourse);
            Controls.Add(dgvData);
            Controls.Add(btnLogout);
            Controls.Add(btnViewTimetable);
            Controls.Add(btnViewMarks);
            Name = "StudentDashboardForm";
            Text = "StudentDashboardForm";
            ((System.ComponentModel.ISupportInitialize)dgvData).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnViewMarks;
        private Button btnViewTimetable;
        private Button btnLogout;
        private DataGridView dgvData;
        private Button btnViewcourse;
        private Button btnExamView;
    }
}