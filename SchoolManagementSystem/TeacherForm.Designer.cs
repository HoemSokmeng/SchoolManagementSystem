namespace SchoolManagementSystem
{
    partial class TeacherForm
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
            addTeacherButton = new Button();
            TeacherDataGridView = new DataGridView();
            groupBox1 = new GroupBox();
            phoneTeacherTextBox = new TextBox();
            label7 = new Label();
            addressTeacherTextBox = new TextBox();
            label6 = new Label();
            salaryTeacherTextBox = new TextBox();
            label5 = new Label();
            subjectTeacherTextBox = new TextBox();
            label4 = new Label();
            nameTeacherTextBox = new TextBox();
            label3 = new Label();
            idTeacherTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            groupBox2 = new GroupBox();
            passwordTextBox = new TextBox();
            label9 = new Label();
            usernameTextBox = new TextBox();
            label8 = new Label();
            saveTeacherButton = new Button();
            updateTeacherButton = new Button();
            closeButton = new Button();
            deleteTeacherButton = new Button();
            ((System.ComponentModel.ISupportInitialize)TeacherDataGridView).BeginInit();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // addTeacherButton
            // 
            addTeacherButton.Location = new Point(621, 682);
            addTeacherButton.Margin = new Padding(4, 5, 4, 5);
            addTeacherButton.Name = "addTeacherButton";
            addTeacherButton.Size = new Size(168, 52);
            addTeacherButton.TabIndex = 0;
            addTeacherButton.Text = "Add New";
            addTeacherButton.UseVisualStyleBackColor = true;
            addTeacherButton.Click += addTeacherButton_Click;
            // 
            // TeacherDataGridView
            // 
            TeacherDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            TeacherDataGridView.Location = new Point(621, 167);
            TeacherDataGridView.Name = "TeacherDataGridView";
            TeacherDataGridView.RowHeadersWidth = 62;
            TeacherDataGridView.RowTemplate.Height = 33;
            TeacherDataGridView.Size = new Size(666, 430);
            TeacherDataGridView.TabIndex = 1;
            TeacherDataGridView.SelectionChanged += TeacherDataGridView_SelectionChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(phoneTeacherTextBox);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(addressTeacherTextBox);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(salaryTeacherTextBox);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(subjectTeacherTextBox);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(nameTeacherTextBox);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(idTeacherTextBox);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 150);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(593, 447);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Teacher Infomation";
            // 
            // phoneTeacherTextBox
            // 
            phoneTeacherTextBox.Location = new Point(284, 378);
            phoneTeacherTextBox.Name = "phoneTeacherTextBox";
            phoneTeacherTextBox.Size = new Size(275, 45);
            phoneTeacherTextBox.TabIndex = 14;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 381);
            label7.Name = "label7";
            label7.Size = new Size(102, 38);
            label7.TabIndex = 13;
            label7.Text = "Phone:";
            // 
            // addressTeacherTextBox
            // 
            addressTeacherTextBox.Location = new Point(284, 318);
            addressTeacherTextBox.Name = "addressTeacherTextBox";
            addressTeacherTextBox.Size = new Size(275, 45);
            addressTeacherTextBox.TabIndex = 12;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(35, 321);
            label6.Name = "label6";
            label6.Size = new Size(122, 38);
            label6.TabIndex = 11;
            label6.Text = "Address:";
            // 
            // salaryTeacherTextBox
            // 
            salaryTeacherTextBox.Location = new Point(284, 258);
            salaryTeacherTextBox.Name = "salaryTeacherTextBox";
            salaryTeacherTextBox.Size = new Size(275, 45);
            salaryTeacherTextBox.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 261);
            label5.Name = "label5";
            label5.Size = new Size(97, 38);
            label5.TabIndex = 9;
            label5.Text = "Salary:";
            // 
            // subjectTeacherTextBox
            // 
            subjectTeacherTextBox.Location = new Point(284, 197);
            subjectTeacherTextBox.Name = "subjectTeacherTextBox";
            subjectTeacherTextBox.Size = new Size(275, 45);
            subjectTeacherTextBox.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(35, 200);
            label4.Name = "label4";
            label4.Size = new Size(114, 38);
            label4.TabIndex = 7;
            label4.Text = "Subject:";
            // 
            // nameTeacherTextBox
            // 
            nameTeacherTextBox.Location = new Point(284, 137);
            nameTeacherTextBox.Name = "nameTeacherTextBox";
            nameTeacherTextBox.Size = new Size(275, 45);
            nameTeacherTextBox.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 140);
            label3.Name = "label3";
            label3.Size = new Size(200, 38);
            label3.TabIndex = 5;
            label3.Text = "Teacher Name:";
            // 
            // idTeacherTextBox
            // 
            idTeacherTextBox.Location = new Point(284, 75);
            idTeacherTextBox.Name = "idTeacherTextBox";
            idTeacherTextBox.Size = new Size(275, 45);
            idTeacherTextBox.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 78);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 3;
            label2.Text = "Teacher ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(398, 25);
            label1.Name = "label1";
            label1.Size = new Size(567, 60);
            label1.TabIndex = 0;
            label1.Text = "Teacher Form Information";
            // 
            // panel1
            // 
            panel1.BackColor = Color.HotPink;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, -3);
            panel1.Name = "panel1";
            panel1.Size = new Size(1300, 109);
            panel1.TabIndex = 1;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(passwordTextBox);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(usernameTextBox);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 603);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(593, 228);
            groupBox2.TabIndex = 15;
            groupBox2.TabStop = false;
            groupBox2.Text = "UserAccount";
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(280, 144);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(275, 45);
            passwordTextBox.TabIndex = 8;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(31, 147);
            label9.Name = "label9";
            label9.Size = new Size(138, 38);
            label9.TabIndex = 7;
            label9.Text = "Password:";
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(280, 76);
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(275, 45);
            usernameTextBox.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(31, 79);
            label8.Name = "label8";
            label8.Size = new Size(148, 38);
            label8.TabIndex = 5;
            label8.Text = "Username:";
            // 
            // saveTeacherButton
            // 
            saveTeacherButton.Location = new Point(851, 682);
            saveTeacherButton.Margin = new Padding(4, 5, 4, 5);
            saveTeacherButton.Name = "saveTeacherButton";
            saveTeacherButton.Size = new Size(168, 52);
            saveTeacherButton.TabIndex = 16;
            saveTeacherButton.Text = "Save";
            saveTeacherButton.UseVisualStyleBackColor = true;
            saveTeacherButton.Click += saveTeacherButton_Click;
            // 
            // updateTeacherButton
            // 
            updateTeacherButton.Location = new Point(1081, 682);
            updateTeacherButton.Margin = new Padding(4, 5, 4, 5);
            updateTeacherButton.Name = "updateTeacherButton";
            updateTeacherButton.Size = new Size(168, 52);
            updateTeacherButton.TabIndex = 17;
            updateTeacherButton.Text = "Update";
            updateTeacherButton.UseVisualStyleBackColor = true;
            updateTeacherButton.Click += updateTeacherButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(985, 768);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(168, 52);
            closeButton.TabIndex = 18;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // deleteTeacherButton
            // 
            deleteTeacherButton.Location = new Point(719, 768);
            deleteTeacherButton.Margin = new Padding(4, 5, 4, 5);
            deleteTeacherButton.Name = "deleteTeacherButton";
            deleteTeacherButton.Size = new Size(168, 52);
            deleteTeacherButton.TabIndex = 19;
            deleteTeacherButton.Text = "Delete";
            deleteTeacherButton.UseVisualStyleBackColor = true;
            deleteTeacherButton.Click += deleteTeacherButton_Click;
            // 
            // TeacherForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LavenderBlush;
            ClientSize = new Size(1299, 861);
            Controls.Add(deleteTeacherButton);
            Controls.Add(closeButton);
            Controls.Add(updateTeacherButton);
            Controls.Add(saveTeacherButton);
            Controls.Add(groupBox2);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Controls.Add(TeacherDataGridView);
            Controls.Add(addTeacherButton);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "TeacherForm";
            Text = "TeacherForm";
            ((System.ComponentModel.ISupportInitialize)TeacherDataGridView).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button addTeacherButton;
        private DataGridView TeacherDataGridView;
        private GroupBox groupBox1;
        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox salaryTeacherTextBox;
        private Label label5;
        private TextBox subjectTeacherTextBox;
        private Label label4;
        private TextBox nameTeacherTextBox;
        private Label label3;
        private TextBox idTeacherTextBox;
        private TextBox phoneTeacherTextBox;
        private Label label7;
        private TextBox addressTeacherTextBox;
        private Label label6;
        private GroupBox groupBox2;
        private TextBox passwordTextBox;
        private Label label9;
        private TextBox usernameTextBox;
        private Label label8;
        private Button saveTeacherButton;
        private Button updateTeacherButton;
        private Button closeButton;
        private Button deleteTeacherButton;
    }
}