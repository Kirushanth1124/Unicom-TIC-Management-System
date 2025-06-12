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
            lable1 = new Label();
            lbl = new Label();
            label2 = new Label();
            label1 = new Label();
            txtStName = new TextBox();
            txtStAddress = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            radMale = new RadioButton();
            radFemale = new RadioButton();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lable1
            // 
            lable1.AutoSize = true;
            lable1.Location = new Point(27, 9);
            lable1.Name = "lable1";
            lable1.Size = new Size(83, 15);
            lable1.TabIndex = 0;
            lable1.Text = "Student Name";
            // 
            // lbl
            // 
            lbl.AutoSize = true;
            lbl.Location = new Point(49, 67);
            lbl.Name = "lbl";
            lbl.Size = new Size(93, 15);
            lbl.TabIndex = 1;
            lbl.Text = "Student Address";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(49, 67);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 43);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 1;
            label1.Text = "Student  Address";
            // 
            // txtStName
            // 
            txtStName.Location = new Point(152, 9);
            txtStName.Name = "txtStName";
            txtStName.Size = new Size(100, 23);
            txtStName.TabIndex = 2;
            txtStName.TextChanged += textBox1_TextChanged;
            // 
            // txtStAddress
            // 
            txtStAddress.Location = new Point(152, 43);
            txtStAddress.Name = "txtStAddress";
            txtStAddress.Size = new Size(100, 23);
            txtStAddress.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 88);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "DOB";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 128);
            label4.Name = "label4";
            label4.Size = new Size(109, 15);
            label4.TabIndex = 6;
            label4.Text = "TelePhone Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(152, 128);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 7;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(152, 86);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 168);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 9;
            label5.Text = "Gender";
            // 
            // radMale
            // 
            radMale.AutoSize = true;
            radMale.Location = new Point(152, 164);
            radMale.Name = "radMale";
            radMale.Size = new Size(51, 19);
            radMale.TabIndex = 10;
            radMale.TabStop = true;
            radMale.Text = "Male";
            radMale.UseVisualStyleBackColor = true;
            // 
            // radFemale
            // 
            radFemale.AutoSize = true;
            radFemale.Location = new Point(243, 164);
            radFemale.Name = "radFemale";
            radFemale.Size = new Size(63, 19);
            radFemale.TabIndex = 11;
            radFemale.TabStop = true;
            radFemale.Text = "Female";
            radFemale.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(27, 207);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            btnUpdate.Location = new Point(152, 207);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 23);
            btnUpdate.TabIndex = 13;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(296, 207);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 14;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(27, 258);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(514, 288);
            dataGridView1.TabIndex = 15;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 567);
            Controls.Add(dataGridView1);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(radFemale);
            Controls.Add(radMale);
            Controls.Add(label5);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtStAddress);
            Controls.Add(txtStName);
            Controls.Add(label1);
            Controls.Add(lable1);
            Name = "StudentForm";
            Text = "0";
            Load += StudentForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lable1;
        private Label lbl;
        private Label label2;
        private Label label1;
        private TextBox txtStName;
        private TextBox txtStAddress;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private DateTimePicker dateTimePicker1;
        private Label label5;
        private RadioButton radMale;
        private RadioButton radFemale;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private DataGridView dataGridView1;
    }
}