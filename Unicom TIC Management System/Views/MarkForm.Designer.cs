﻿namespace Unicom_TIC_Management_System.Views
{
    partial class MarkForm
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
            label2 = new Label();
            label3 = new Label();
            comboBoxStudents = new ComboBox();
            comboBoxExams = new ComboBox();
            txtScore = new TextBox();
            btnAdd = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            dataGridViewMarks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 44);
            label1.Name = "label1";
            label1.Size = new Size(70, 21);
            label1.TabIndex = 0;
            label1.Text = "Student";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 90);
            label2.Name = "label2";
            label2.Size = new Size(52, 21);
            label2.TabIndex = 1;
            label2.Text = "Exam";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 135);
            label3.Name = "label3";
            label3.Size = new Size(52, 21);
            label3.TabIndex = 2;
            label3.Text = "Score";
            // 
            // comboBoxStudents
            // 
            comboBoxStudents.FormattingEnabled = true;
            comboBoxStudents.Location = new Point(160, 44);
            comboBoxStudents.Name = "comboBoxStudents";
            comboBoxStudents.Size = new Size(121, 23);
            comboBoxStudents.TabIndex = 3;
            // 
            // comboBoxExams
            // 
            comboBoxExams.FormattingEnabled = true;
            comboBoxExams.Location = new Point(160, 90);
            comboBoxExams.Name = "comboBoxExams";
            comboBoxExams.Size = new Size(121, 23);
            comboBoxExams.TabIndex = 4;
            // 
            // txtScore
            // 
            txtScore.Location = new Point(160, 135);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(121, 23);
            txtScore.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(41, 189);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 25);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click_1;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(347, 192);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 25);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click_1;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Algerian", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnUpdate.Location = new Point(186, 189);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(95, 28);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // dataGridViewMarks
            // 
            dataGridViewMarks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMarks.Location = new Point(77, 251);
            dataGridViewMarks.Name = "dataGridViewMarks";
            dataGridViewMarks.Size = new Size(423, 194);
            dataGridViewMarks.TabIndex = 9;
            dataGridViewMarks.CellContentClick += dataGridViewMarks_CellContentClick;
            // 
            // MarkForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewMarks);
            Controls.Add(btnUpdate);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(txtScore);
            Controls.Add(comboBoxExams);
            Controls.Add(comboBoxStudents);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "MarkForm";
            Text = "MarkForm";
            ((System.ComponentModel.ISupportInitialize)dataGridViewMarks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private ComboBox comboBoxStudents;
        private ComboBox comboBoxExams;
        private TextBox txtScore;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnUpdate;
        private DataGridView dataGridViewMarks;
    }
}