namespace Unicom_TIC_Management_System.Views
{
    partial class LecturerDashboardForm
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
            btnViewTimetable = new Button();
            btnLogout = new Button();
            btnViewExams = new Button();
            groupActions = new GroupBox();
            SuspendLayout();
            // 
            // btnViewTimetable
            // 
            btnViewTimetable.Location = new Point(80, 39);
            btnViewTimetable.Name = "btnViewTimetable";
            btnViewTimetable.Size = new Size(121, 23);
            btnViewTimetable.TabIndex = 0;
            btnViewTimetable.Text = "View TimeTable";
            btnViewTimetable.UseVisualStyleBackColor = true;
            // 
            // btnLogout
            // 
            btnLogout.Location = new Point(80, 363);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 23);
            btnLogout.TabIndex = 1;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnViewExams
            // 
            btnViewExams.Location = new Point(80, 116);
            btnViewExams.Name = "btnViewExams";
            btnViewExams.Size = new Size(121, 23);
            btnViewExams.TabIndex = 2;
            btnViewExams.Text = "View Exam";
            btnViewExams.UseVisualStyleBackColor = true;
            // 
            // groupActions
            // 
            groupActions.Location = new Point(272, 21);
            groupActions.Name = "groupActions";
            groupActions.Size = new Size(516, 247);
            groupActions.TabIndex = 3;
            groupActions.TabStop = false;
            groupActions.Text = "groupBox1";
            // 
            // LecturerDashboardForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupActions);
            Controls.Add(btnViewExams);
            Controls.Add(btnLogout);
            Controls.Add(btnViewTimetable);
            Name = "LecturerDashboardForm";
            Text = "LecturerDashboardForm";
            ResumeLayout(false);
        }

        #endregion

        private Button btnViewTimetable;
        private Button btnLogout;
        private Button btnViewExams;
        private GroupBox groupActions;
    }
}