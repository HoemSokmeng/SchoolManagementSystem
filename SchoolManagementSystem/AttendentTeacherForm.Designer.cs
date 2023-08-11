namespace SchoolManagementSystem
{
    partial class AttendentTeacherForm
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
            panel1 = new Panel();
            label1 = new Label();
            timer = new System.Windows.Forms.Timer(components);
            idTeacherTextBox = new TextBox();
            label2 = new Label();
            timeInTeacherButton = new Button();
            timeOutTeacherButton = new Button();
            closeButton = new Button();
            currentTimeLabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumOrchid;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1040, 98);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(325, 19);
            label1.Name = "label1";
            label1.Size = new Size(379, 60);
            label1.TabIndex = 0;
            label1.Text = "Attendent Teacher";
            // 
            // timer
            // 
            timer.Enabled = true;
            timer.Interval = 10;
            timer.Tick += timer_Tick;
            // 
            // idTeacherTextBox
            // 
            idTeacherTextBox.Location = new Point(500, 233);
            idTeacherTextBox.Name = "idTeacherTextBox";
            idTeacherTextBox.Size = new Size(260, 45);
            idTeacherTextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(241, 240);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 2;
            label2.Text = "Teacher ID:";
            // 
            // timeInTeacherButton
            // 
            timeInTeacherButton.Location = new Point(186, 340);
            timeInTeacherButton.Name = "timeInTeacherButton";
            timeInTeacherButton.Size = new Size(151, 50);
            timeInTeacherButton.TabIndex = 3;
            timeInTeacherButton.Text = "Time-In";
            timeInTeacherButton.UseVisualStyleBackColor = true;
            timeInTeacherButton.Click += timeInTeacherButton_Click;
            // 
            // timeOutTeacherButton
            // 
            timeOutTeacherButton.Location = new Point(455, 340);
            timeOutTeacherButton.Name = "timeOutTeacherButton";
            timeOutTeacherButton.Size = new Size(170, 50);
            timeOutTeacherButton.TabIndex = 4;
            timeOutTeacherButton.Text = "Time-Out";
            timeOutTeacherButton.UseVisualStyleBackColor = true;
            timeOutTeacherButton.Click += timeOutTeacherButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(712, 340);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 50);
            closeButton.TabIndex = 5;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // currentTimeLabel
            // 
            currentTimeLabel.AutoSize = true;
            currentTimeLabel.Location = new Point(392, 143);
            currentTimeLabel.MaximumSize = new Size(600, 0);
            currentTimeLabel.MinimumSize = new Size(600, 0);
            currentTimeLabel.Name = "currentTimeLabel";
            currentTimeLabel.Size = new Size(600, 38);
            currentTimeLabel.TabIndex = 6;
            currentTimeLabel.Text = "Time";
            // 
            // AttendentTeacherForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Thistle;
            ClientSize = new Size(1042, 464);
            Controls.Add(currentTimeLabel);
            Controls.Add(closeButton);
            Controls.Add(timeOutTeacherButton);
            Controls.Add(timeInTeacherButton);
            Controls.Add(label2);
            Controls.Add(idTeacherTextBox);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            Name = "AttendentTeacherForm";
            Text = "AttendentTeacherForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private System.Windows.Forms.Timer timer;
        private TextBox idTeacherTextBox;
        private Label label2;
        private Button timeInTeacherButton;
        private Button timeOutTeacherButton;
        private Button closeButton;
        private Label currentTimeLabel;
    }
}