namespace SchoolManagementSystem
{
    partial class AttendentStudentForm
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
            components = new System.ComponentModel.Container();
            timeInStudentButton = new Button();
            label1 = new Label();
            panel1 = new Panel();
            timer = new System.Windows.Forms.Timer(components);
            attenStudentTextBox = new TextBox();
            label2 = new Label();
            timeOutStudentButton = new Button();
            closeButton = new Button();
            currentTimeLabelStudent = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // timeInStudentButton
            // 
            timeInStudentButton.Location = new Point(196, 323);
            timeInStudentButton.Margin = new Padding(4, 5, 4, 5);
            timeInStudentButton.Name = "timeInStudentButton";
            timeInStudentButton.Size = new Size(168, 52);
            timeInStudentButton.TabIndex = 0;
            timeInStudentButton.Text = "Time-In";
            timeInStudentButton.UseVisualStyleBackColor = true;
            timeInStudentButton.Click += timeInStudentButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(388, 24);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(383, 60);
            label1.TabIndex = 1;
            label1.Text = "Attendent Student";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Yellow;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(2, -1);
            panel1.Margin = new Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new Size(1199, 109);
            panel1.TabIndex = 2;
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            // 
            // attenStudentTextBox
            // 
            attenStudentTextBox.Location = new Point(572, 238);
            attenStudentTextBox.Margin = new Padding(4, 5, 4, 5);
            attenStudentTextBox.Name = "attenStudentTextBox";
            attenStudentTextBox.Size = new Size(223, 45);
            attenStudentTextBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(295, 241);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 2;
            label2.Text = "Student ID:";
            // 
            // timeOutStudentButton
            // 
            timeOutStudentButton.Location = new Point(486, 323);
            timeOutStudentButton.Margin = new Padding(4, 5, 4, 5);
            timeOutStudentButton.Name = "timeOutStudentButton";
            timeOutStudentButton.Size = new Size(168, 52);
            timeOutStudentButton.TabIndex = 4;
            timeOutStudentButton.Text = "Time-Out";
            timeOutStudentButton.UseVisualStyleBackColor = true;
            timeOutStudentButton.Click += timeOutStudentButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(719, 323);
            closeButton.Margin = new Padding(4, 5, 4, 5);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(168, 52);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // currentTimeLabelStudent
            // 
            currentTimeLabelStudent.AutoSize = true;
            currentTimeLabelStudent.Location = new Point(442, 141);
            currentTimeLabelStudent.Margin = new Padding(4, 0, 4, 0);
            currentTimeLabelStudent.MaximumSize = new Size(600, 0);
            currentTimeLabelStudent.MinimumSize = new Size(600, 0);
            currentTimeLabelStudent.Name = "currentTimeLabelStudent";
            currentTimeLabelStudent.Size = new Size(600, 38);
            currentTimeLabelStudent.TabIndex = 6;
            currentTimeLabelStudent.Text = "Time";
            // 
            // AttendentStudentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 255, 192);
            ClientSize = new Size(1157, 455);
            Controls.Add(currentTimeLabelStudent);
            Controls.Add(closeButton);
            Controls.Add(timeOutStudentButton);
            Controls.Add(label2);
            Controls.Add(attenStudentTextBox);
            Controls.Add(panel1);
            Controls.Add(timeInStudentButton);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AttendentStudentForm";
            Text = "AttendentStudentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button timeInStudentButton;
        private Label label1;
        private Panel panel1;
        private System.Windows.Forms.Timer timer;
        private TextBox attenStudentTextBox;
        private Label label2;
        private Button timeOutStudentButton;
        private Button closeButton;
        private Label currentTimeLabelStudent;
    }
}