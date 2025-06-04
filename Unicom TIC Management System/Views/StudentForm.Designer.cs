namespace Unicom_TIC_Management_System.Views
{
    partial class StudentForm
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
            lblSName = new Label();
            lblSCourse = new Label();
            textBox1 = new TextBox();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // lblSName
            // 
            lblSName.AutoSize = true;
            lblSName.Location = new Point(55, 37);
            lblSName.Name = "lblSName";
            lblSName.Size = new Size(38, 15);
            lblSName.TabIndex = 0;
            lblSName.Text = "label1";
            // 
            // lblSCourse
            // 
            lblSCourse.AutoSize = true;
            lblSCourse.Location = new Point(55, 87);
            lblSCourse.Name = "lblSCourse";
            lblSCourse.Size = new Size(38, 15);
            lblSCourse.TabIndex = 1;
            lblSCourse.Text = "label2";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 37);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(121, 23);
            textBox1.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(166, 87);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 3;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox1);
            Controls.Add(textBox1);
            Controls.Add(lblSCourse);
            Controls.Add(lblSName);
            Name = "StudentForm";
            Text = "StudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblSName;
        private Label lblSCourse;
        private TextBox textBox1;
        private ComboBox comboBox1;
    }
}