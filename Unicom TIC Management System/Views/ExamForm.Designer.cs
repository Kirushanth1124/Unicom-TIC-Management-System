namespace Unicom_TIC_Management_System.Views
{
    partial class ExamForm
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
            label1 = new Label();
            txtExamName = new TextBox();
            comboBoxSubjects = new ComboBox();
            label2 = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridViewExams = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExams).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 40);
            label1.Name = "label1";
            label1.Size = new Size(70, 15);
            label1.TabIndex = 0;
            label1.Text = "Exam Name";
            // 
            // txtExamName
            // 
            txtExamName.Location = new Point(234, 40);
            txtExamName.Name = "txtExamName";
            txtExamName.Size = new Size(100, 23);
            txtExamName.TabIndex = 1;
            // 
            // comboBoxSubjects
            // 
            comboBoxSubjects.FormattingEnabled = true;
            comboBoxSubjects.Location = new Point(234, 91);
            comboBoxSubjects.Name = "comboBoxSubjects";
            comboBoxSubjects.Size = new Size(121, 23);
            comboBoxSubjects.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 99);
            label2.Name = "label2";
            label2.Size = new Size(78, 15);
            label2.TabIndex = 3;
            label2.Text = "Select Course";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(89, 156);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 4;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(376, 156);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 5;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(234, 156);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 6;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // dataGridViewExams
            // 
            dataGridViewExams.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExams.Location = new Point(106, 219);
            dataGridViewExams.Name = "dataGridViewExams";
            dataGridViewExams.Size = new Size(409, 181);
            dataGridViewExams.TabIndex = 7;
            // 
            // ExamForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewExams);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(label2);
            Controls.Add(comboBoxSubjects);
            Controls.Add(txtExamName);
            Controls.Add(label1);
            Name = "ExamForm";
            Text = "ExamForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewExams).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtExamName;
        private ComboBox comboBoxSubjects;
        private Label label2;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridViewExams;
    }
}