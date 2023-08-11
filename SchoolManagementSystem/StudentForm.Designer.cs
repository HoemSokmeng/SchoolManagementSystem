namespace SchoolManagementSystem
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
            panel1 = new Panel();
            label1 = new Label();
            addStudentButton = new Button();
            studentDataGridView = new DataGridView();
            dateTimePickerStudent = new DateTimePicker();
            label2 = new Label();
            idStudentTextBox = new TextBox();
            label3 = new Label();
            nameStudentTextBox = new TextBox();
            label4 = new Label();
            sexStudentTextBox = new TextBox();
            label5 = new Label();
            addressStudentTextBox = new TextBox();
            label6 = new Label();
            phoneStudentTextBox = new TextBox();
            label7 = new Label();
            departmentStudentTextBox = new TextBox();
            label8 = new Label();
            saveStudentButton = new Button();
            updateStudentButton = new Button();
            closeButton = new Button();
            deleteStudentButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SaddleBrown;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1281, 112);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(389, 24);
            label1.Name = "label1";
            label1.Size = new Size(571, 60);
            label1.TabIndex = 3;
            label1.Text = "Student Form Information";
            // 
            // addStudentButton
            // 
            addStudentButton.Location = new Point(597, 354);
            addStudentButton.Name = "addStudentButton";
            addStudentButton.Size = new Size(161, 50);
            addStudentButton.TabIndex = 0;
            addStudentButton.Text = "Add New";
            addStudentButton.UseVisualStyleBackColor = true;
            addStudentButton.Click += addStudentButton_Click;
            // 
            // studentDataGridView
            // 
            studentDataGridView.BackgroundColor = Color.Bisque;
            studentDataGridView.BorderStyle = BorderStyle.None;
            studentDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            studentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            studentDataGridView.Location = new Point(12, 472);
            studentDataGridView.Name = "studentDataGridView";
            studentDataGridView.RowHeadersWidth = 62;
            studentDataGridView.RowTemplate.Height = 33;
            studentDataGridView.Size = new Size(1258, 256);
            studentDataGridView.TabIndex = 1;
            studentDataGridView.SelectionChanged += studentDataGridView_SelectionChanged;
            // 
            // dateTimePickerStudent
            // 
            dateTimePickerStudent.CustomFormat = "dd/MM/yyyy";
            dateTimePickerStudent.Format = DateTimePickerFormat.Custom;
            dateTimePickerStudent.Location = new Point(299, 354);
            dateTimePickerStudent.Name = "dateTimePickerStudent";
            dateTimePickerStudent.Size = new Size(269, 45);
            dateTimePickerStudent.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 167);
            label2.Name = "label2";
            label2.Size = new Size(151, 38);
            label2.TabIndex = 4;
            label2.Text = "Identity ID:";
            // 
            // idStudentTextBox
            // 
            idStudentTextBox.Location = new Point(299, 164);
            idStudentTextBox.Name = "idStudentTextBox";
            idStudentTextBox.Size = new Size(248, 45);
            idStudentTextBox.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 227);
            label3.Name = "label3";
            label3.Size = new Size(200, 38);
            label3.TabIndex = 6;
            label3.Text = "Student Name:";
            // 
            // nameStudentTextBox
            // 
            nameStudentTextBox.Location = new Point(299, 224);
            nameStudentTextBox.Name = "nameStudentTextBox";
            nameStudentTextBox.Size = new Size(248, 45);
            nameStudentTextBox.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(72, 288);
            label4.Name = "label4";
            label4.Size = new Size(114, 38);
            label4.TabIndex = 8;
            label4.Text = "Gender:";
            // 
            // sexStudentTextBox
            // 
            sexStudentTextBox.Location = new Point(299, 285);
            sexStudentTextBox.Name = "sexStudentTextBox";
            sexStudentTextBox.Size = new Size(248, 45);
            sexStudentTextBox.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(714, 167);
            label5.Name = "label5";
            label5.Size = new Size(122, 38);
            label5.TabIndex = 10;
            label5.Text = "Address:";
            // 
            // addressStudentTextBox
            // 
            addressStudentTextBox.Location = new Point(910, 164);
            addressStudentTextBox.Name = "addressStudentTextBox";
            addressStudentTextBox.Size = new Size(261, 45);
            addressStudentTextBox.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(714, 227);
            label6.Name = "label6";
            label6.Size = new Size(102, 38);
            label6.TabIndex = 12;
            label6.Text = "Phone:";
            // 
            // phoneStudentTextBox
            // 
            phoneStudentTextBox.Location = new Point(910, 224);
            phoneStudentTextBox.Name = "phoneStudentTextBox";
            phoneStudentTextBox.Size = new Size(261, 45);
            phoneStudentTextBox.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(714, 288);
            label7.Name = "label7";
            label7.Size = new Size(171, 38);
            label7.TabIndex = 14;
            label7.Text = "Department:";
            // 
            // departmentStudentTextBox
            // 
            departmentStudentTextBox.Location = new Point(910, 285);
            departmentStudentTextBox.Name = "departmentStudentTextBox";
            departmentStudentTextBox.Size = new Size(261, 45);
            departmentStudentTextBox.TabIndex = 15;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 359);
            label8.Name = "label8";
            label8.Size = new Size(129, 38);
            label8.TabIndex = 16;
            label8.Text = "BirthDay:";
            // 
            // saveStudentButton
            // 
            saveStudentButton.Location = new Point(775, 354);
            saveStudentButton.Name = "saveStudentButton";
            saveStudentButton.Size = new Size(132, 50);
            saveStudentButton.TabIndex = 17;
            saveStudentButton.Text = "Save";
            saveStudentButton.UseVisualStyleBackColor = true;
            saveStudentButton.Click += saveStudentButton_Click;
            // 
            // updateStudentButton
            // 
            updateStudentButton.Location = new Point(608, 410);
            updateStudentButton.Name = "updateStudentButton";
            updateStudentButton.Size = new Size(132, 50);
            updateStudentButton.TabIndex = 18;
            updateStudentButton.Text = "Update";
            updateStudentButton.UseVisualStyleBackColor = true;
            updateStudentButton.Click += updateStudentButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(949, 375);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 50);
            closeButton.TabIndex = 19;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // deleteStudentButton
            // 
            deleteStudentButton.Location = new Point(775, 410);
            deleteStudentButton.Name = "deleteStudentButton";
            deleteStudentButton.Size = new Size(132, 50);
            deleteStudentButton.TabIndex = 20;
            deleteStudentButton.Text = "Delete";
            deleteStudentButton.UseVisualStyleBackColor = true;
            deleteStudentButton.Click += deleteStudentButton_Click;
            // 
            // StudentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Tan;
            ClientSize = new Size(1282, 740);
            Controls.Add(deleteStudentButton);
            Controls.Add(closeButton);
            Controls.Add(updateStudentButton);
            Controls.Add(saveStudentButton);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(departmentStudentTextBox);
            Controls.Add(label6);
            Controls.Add(phoneStudentTextBox);
            Controls.Add(label5);
            Controls.Add(addressStudentTextBox);
            Controls.Add(label4);
            Controls.Add(sexStudentTextBox);
            Controls.Add(label3);
            Controls.Add(nameStudentTextBox);
            Controls.Add(addStudentButton);
            Controls.Add(studentDataGridView);
            Controls.Add(dateTimePickerStudent);
            Controls.Add(label2);
            Controls.Add(idStudentTextBox);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "StudentForm";
            Text = "StudentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)studentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button addStudentButton;
        private DataGridView studentDataGridView;
        private DateTimePicker dateTimePickerStudent;
        private Label label2;
        private TextBox idStudentTextBox;
        private Label label3;
        private TextBox nameStudentTextBox;
        private Label label4;
        private TextBox sexStudentTextBox;
        private Label label5;
        private TextBox addressStudentTextBox;
        private Label label6;
        private TextBox phoneStudentTextBox;
        private Label label7;
        private TextBox departmentStudentTextBox;
        private Label label8;
        private Button saveStudentButton;
        private Button updateStudentButton;
        private Button closeButton;
        private Button deleteStudentButton;
    }
}