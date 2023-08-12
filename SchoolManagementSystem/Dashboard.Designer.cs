namespace SchoolManagementSystem
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            panel1 = new Panel();
            label1 = new Label();
            button2 = new Button();
            label3 = new Label();
            label4 = new Label();
            teacherPictureBox = new PictureBox();
            label5 = new Label();
            studentPictureBox = new PictureBox();
            label6 = new Label();
            attendentTeacherPictureBox = new PictureBox();
            panel2 = new Panel();
            label2 = new Label();
            label7 = new Label();
            attendentStudentPictureBox = new PictureBox();
            label8 = new Label();
            scoreStudentPictureBox = new PictureBox();
            departmentPictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)teacherPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)attendentTeacherPictureBox).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)attendentStudentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)scoreStudentPictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)departmentPictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1202, 125);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(274, 34);
            label1.Name = "label1";
            label1.Size = new Size(505, 54);
            label1.TabIndex = 1;
            label1.Text = "School Management System";
            // 
            // button2
            // 
            button2.BackColor = Color.Red;
            button2.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ButtonHighlight;
            button2.Location = new Point(1008, 35);
            button2.Name = "button2";
            button2.Size = new Size(103, 60);
            button2.TabIndex = 2;
            button2.Text = "X";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(109, 380);
            label3.Name = "label3";
            label3.Size = new Size(158, 37);
            label3.TabIndex = 5;
            label3.Text = "Department";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point);
            label4.Location = new Point(497, 380);
            label4.Name = "label4";
            label4.Size = new Size(109, 37);
            label4.TabIndex = 7;
            label4.Text = "Teacher";
            // 
            // teacherPictureBox
            // 
            teacherPictureBox.Image = (Image)resources.GetObject("teacherPictureBox.Image");
            teacherPictureBox.Location = new Point(449, 151);
            teacherPictureBox.Name = "teacherPictureBox";
            teacherPictureBox.Size = new Size(224, 226);
            teacherPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            teacherPictureBox.TabIndex = 6;
            teacherPictureBox.TabStop = false;
            teacherPictureBox.Click += teacherPictureBox_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(859, 380);
            label5.Name = "label5";
            label5.Size = new Size(106, 37);
            label5.TabIndex = 9;
            label5.Text = "Student";
            // 
            // studentPictureBox
            // 
            studentPictureBox.Image = (Image)resources.GetObject("studentPictureBox.Image");
            studentPictureBox.Location = new Point(811, 151);
            studentPictureBox.Name = "studentPictureBox";
            studentPictureBox.Size = new Size(224, 226);
            studentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            studentPictureBox.TabIndex = 8;
            studentPictureBox.TabStop = false;
            studentPictureBox.Click += studentPictureBox_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(60, 681);
            label6.Name = "label6";
            label6.Size = new Size(231, 37);
            label6.TabIndex = 11;
            label6.Text = "Attendent Teacher";
            // 
            // attendentTeacherPictureBox
            // 
            attendentTeacherPictureBox.Image = (Image)resources.GetObject("attendentTeacherPictureBox.Image");
            attendentTeacherPictureBox.Location = new Point(90, 452);
            attendentTeacherPictureBox.Name = "attendentTeacherPictureBox";
            attendentTeacherPictureBox.Size = new Size(227, 226);
            attendentTeacherPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            attendentTeacherPictureBox.TabIndex = 10;
            attendentTeacherPictureBox.TabStop = false;
            attendentTeacherPictureBox.Click += attendentTeacherPictureBox_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Pink;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 756);
            panel2.Name = "panel2";
            panel2.Size = new Size(1149, 136);
            panel2.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 24F, FontStyle.Italic, GraphicsUnit.Point);
            label2.Location = new Point(341, 14);
            label2.Name = "label2";
            label2.Size = new Size(362, 54);
            label2.TabIndex = 1;
            label2.Text = "Assignment Group3";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point);
            label7.Location = new Point(422, 681);
            label7.Name = "label7";
            label7.Size = new Size(228, 37);
            label7.TabIndex = 14;
            label7.Text = "Attendent Student";
            // 
            // attendentStudentPictureBox
            // 
            attendentStudentPictureBox.Image = (Image)resources.GetObject("attendentStudentPictureBox.Image");
            attendentStudentPictureBox.Location = new Point(423, 452);
            attendentStudentPictureBox.Name = "attendentStudentPictureBox";
            attendentStudentPictureBox.Size = new Size(227, 226);
            attendentStudentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            attendentStudentPictureBox.TabIndex = 13;
            attendentStudentPictureBox.TabStop = false;
            attendentStudentPictureBox.Click += attendentStudentPictureBox_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 16F, FontStyle.Italic, GraphicsUnit.Point);
            label8.Location = new Point(821, 681);
            label8.Name = "label8";
            label8.Size = new Size(175, 37);
            label8.TabIndex = 16;
            label8.Text = "Score Student";
            // 
            // scoreStudentPictureBox
            // 
            scoreStudentPictureBox.Image = (Image)resources.GetObject("scoreStudentPictureBox.Image");
            scoreStudentPictureBox.Location = new Point(811, 452);
            scoreStudentPictureBox.Name = "scoreStudentPictureBox";
            scoreStudentPictureBox.Size = new Size(227, 226);
            scoreStudentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            scoreStudentPictureBox.TabIndex = 15;
            scoreStudentPictureBox.TabStop = false;
            scoreStudentPictureBox.Click += scoreStudentPictureBox_Click;
            // 
            // departmentPictureBox
            // 
            departmentPictureBox.Image = (Image)resources.GetObject("departmentPictureBox.Image");
            departmentPictureBox.Location = new Point(90, 151);
            departmentPictureBox.Name = "departmentPictureBox";
            departmentPictureBox.Size = new Size(227, 226);
            departmentPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            departmentPictureBox.TabIndex = 17;
            departmentPictureBox.TabStop = false;
            departmentPictureBox.Click += departmentPictureBox_Click;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MediumTurquoise;
            ClientSize = new Size(1148, 853);
            Controls.Add(departmentPictureBox);
            Controls.Add(label8);
            Controls.Add(scoreStudentPictureBox);
            Controls.Add(label7);
            Controls.Add(attendentStudentPictureBox);
            Controls.Add(panel2);
            Controls.Add(label6);
            Controls.Add(attendentTeacherPictureBox);
            Controls.Add(label5);
            Controls.Add(studentPictureBox);
            Controls.Add(label4);
            Controls.Add(teacherPictureBox);
            Controls.Add(label3);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "Dashboard";
            Text = "Dashboard";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)teacherPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)attendentTeacherPictureBox).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)attendentStudentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)scoreStudentPictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)departmentPictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Label label1;
        private Label label3;
        private Label label4;
        private PictureBox teacherPictureBox;
        private Label label5;
        private PictureBox studentPictureBox;
        private Label label6;
        private PictureBox attendentTeacherPictureBox;
        private Panel panel2;
        private Label label2;
        private Label label7;
        private PictureBox attendentStudentPictureBox;
        private Label label8;
        private PictureBox scoreStudentPictureBox;
        private PictureBox departmentPictureBox;
    }
}