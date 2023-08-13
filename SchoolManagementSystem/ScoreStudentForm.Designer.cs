namespace SchoolManagementSystem
{
    partial class ScoreStudentForm
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
            idScoreStudentTextBox = new TextBox();
            scoreStudentDataGridView = new DataGridView();
            addScoreStudentButton = new Button();
            label2 = new Label();
            label3 = new Label();
            nameScoreStudentTextBox = new TextBox();
            label4 = new Label();
            javaTextBox = new TextBox();
            label5 = new Label();
            pythonTextBox = new TextBox();
            label6 = new Label();
            cshapTextBox = new TextBox();
            label7 = new Label();
            bigDataTextBox = new TextBox();
            label8 = new Label();
            englishTextBox = new TextBox();
            label9 = new Label();
            totalLabel = new Label();
            label11 = new Label();
            lableAverage = new Label();
            label13 = new Label();
            gradeLabel = new Label();
            saveScoreStudentButton = new Button();
            updateScoreStudentButton = new Button();
            closeButton = new Button();
            deleteScoreStudentButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)scoreStudentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Lime;
            panel1.Controls.Add(label1);
            panel1.ForeColor = SystemColors.ButtonHighlight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1351, 107);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(450, 23);
            label1.Name = "label1";
            label1.Size = new Size(435, 60);
            label1.TabIndex = 1;
            label1.Text = "Score Student Form";
            // 
            // idScoreStudentTextBox
            // 
            idScoreStudentTextBox.Location = new Point(405, 129);
            idScoreStudentTextBox.Name = "idScoreStudentTextBox";
            idScoreStudentTextBox.Size = new Size(212, 45);
            idScoreStudentTextBox.TabIndex = 0;
            // 
            // scoreStudentDataGridView
            // 
            scoreStudentDataGridView.BackgroundColor = Color.FromArgb(192, 255, 192);
            scoreStudentDataGridView.BorderStyle = BorderStyle.None;
            scoreStudentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            scoreStudentDataGridView.Location = new Point(12, 579);
            scoreStudentDataGridView.Name = "scoreStudentDataGridView";
            scoreStudentDataGridView.RowHeadersWidth = 62;
            scoreStudentDataGridView.RowTemplate.Height = 33;
            scoreStudentDataGridView.Size = new Size(1327, 313);
            scoreStudentDataGridView.TabIndex = 2;
            scoreStudentDataGridView.SelectionChanged += scoreStudentDataGridView_SelectionChanged;
            // 
            // addScoreStudentButton
            // 
            addScoreStudentButton.Location = new Point(463, 511);
            addScoreStudentButton.Name = "addScoreStudentButton";
            addScoreStudentButton.Size = new Size(154, 52);
            addScoreStudentButton.TabIndex = 3;
            addScoreStudentButton.Text = "Add New";
            addScoreStudentButton.UseVisualStyleBackColor = true;
            addScoreStudentButton.Click += addScoreStudentButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(192, 136);
            label2.Name = "label2";
            label2.Size = new Size(153, 38);
            label2.TabIndex = 4;
            label2.Text = "Student ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(145, 210);
            label3.Name = "label3";
            label3.Size = new Size(200, 38);
            label3.TabIndex = 6;
            label3.Text = "Student Name:";
            // 
            // nameScoreStudentTextBox
            // 
            nameScoreStudentTextBox.Location = new Point(405, 203);
            nameScoreStudentTextBox.Name = "nameScoreStudentTextBox";
            nameScoreStudentTextBox.Size = new Size(212, 45);
            nameScoreStudentTextBox.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(271, 279);
            label4.Name = "label4";
            label4.Size = new Size(74, 38);
            label4.TabIndex = 8;
            label4.Text = "Java:";
            // 
            // javaTextBox
            // 
            javaTextBox.Location = new Point(405, 276);
            javaTextBox.Name = "javaTextBox";
            javaTextBox.Size = new Size(212, 45);
            javaTextBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(777, 129);
            label5.Name = "label5";
            label5.Size = new Size(110, 38);
            label5.TabIndex = 10;
            label5.Text = "Python:";
            // 
            // pythonTextBox
            // 
            pythonTextBox.Location = new Point(962, 129);
            pythonTextBox.Name = "pythonTextBox";
            pythonTextBox.Size = new Size(212, 45);
            pythonTextBox.TabIndex = 9;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(777, 203);
            label6.Name = "label6";
            label6.Size = new Size(98, 38);
            label6.TabIndex = 12;
            label6.Text = "Cshap:";
            // 
            // cshapTextBox
            // 
            cshapTextBox.Location = new Point(962, 203);
            cshapTextBox.Name = "cshapTextBox";
            cshapTextBox.Size = new Size(212, 45);
            cshapTextBox.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(777, 280);
            label7.Name = "label7";
            label7.Size = new Size(127, 38);
            label7.TabIndex = 14;
            label7.Text = "Big Data:";
            // 
            // bigDataTextBox
            // 
            bigDataTextBox.Location = new Point(962, 280);
            bigDataTextBox.Name = "bigDataTextBox";
            bigDataTextBox.Size = new Size(212, 45);
            bigDataTextBox.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(611, 349);
            label8.Name = "label8";
            label8.Size = new Size(111, 38);
            label8.TabIndex = 16;
            label8.Text = "English:";
            // 
            // englishTextBox
            // 
            englishTextBox.Location = new Point(748, 342);
            englishTextBox.Name = "englishTextBox";
            englishTextBox.Size = new Size(212, 45);
            englishTextBox.TabIndex = 15;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 433);
            label9.Name = "label9";
            label9.Size = new Size(89, 38);
            label9.TabIndex = 17;
            label9.Text = "Total: ";
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new Point(282, 433);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new Size(0, 38);
            totalLabel.TabIndex = 18;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(517, 433);
            label11.Name = "label11";
            label11.Size = new Size(123, 38);
            label11.TabIndex = 19;
            label11.Text = "Average:";
            // 
            // lableAverage
            // 
            lableAverage.AutoSize = true;
            lableAverage.Location = new Point(646, 433);
            lableAverage.Name = "lableAverage";
            lableAverage.Size = new Size(0, 38);
            lableAverage.TabIndex = 20;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(929, 433);
            label13.Name = "label13";
            label13.Size = new Size(97, 38);
            label13.TabIndex = 21;
            label13.Text = "Grade:";
            // 
            // gradeLabel
            // 
            gradeLabel.AutoSize = true;
            gradeLabel.Location = new Point(1032, 433);
            gradeLabel.Name = "gradeLabel";
            gradeLabel.Size = new Size(0, 38);
            gradeLabel.TabIndex = 22;
            // 
            // saveScoreStudentButton
            // 
            saveScoreStudentButton.Location = new Point(668, 511);
            saveScoreStudentButton.Name = "saveScoreStudentButton";
            saveScoreStudentButton.Size = new Size(112, 52);
            saveScoreStudentButton.TabIndex = 23;
            saveScoreStudentButton.Text = "Save";
            saveScoreStudentButton.UseVisualStyleBackColor = true;
            saveScoreStudentButton.Click += saveScoreStudentButton_Click;
            // 
            // updateScoreStudentButton
            // 
            updateScoreStudentButton.Location = new Point(816, 511);
            updateScoreStudentButton.Name = "updateScoreStudentButton";
            updateScoreStudentButton.Size = new Size(134, 52);
            updateScoreStudentButton.TabIndex = 24;
            updateScoreStudentButton.Text = "Update";
            updateScoreStudentButton.UseVisualStyleBackColor = true;
            updateScoreStudentButton.Click += updateScoreStudentButton_Click;
            // 
            // closeButton
            // 
            closeButton.Location = new Point(1153, 511);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(112, 52);
            closeButton.TabIndex = 25;
            closeButton.Text = "Close";
            closeButton.UseVisualStyleBackColor = true;
            closeButton.Click += closeButton_Click;
            // 
            // deleteScoreStudentButton
            // 
            deleteScoreStudentButton.Location = new Point(975, 511);
            deleteScoreStudentButton.Name = "deleteScoreStudentButton";
            deleteScoreStudentButton.Size = new Size(134, 52);
            deleteScoreStudentButton.TabIndex = 26;
            deleteScoreStudentButton.Text = "Delete";
            deleteScoreStudentButton.UseVisualStyleBackColor = true;
            deleteScoreStudentButton.Click += deleteScoreStudentButton_Click;
            // 
            // ScoreStudentForm
            // 
            AutoScaleDimensions = new SizeF(15F, 38F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1351, 945);
            Controls.Add(deleteScoreStudentButton);
            Controls.Add(closeButton);
            Controls.Add(updateScoreStudentButton);
            Controls.Add(saveScoreStudentButton);
            Controls.Add(gradeLabel);
            Controls.Add(label13);
            Controls.Add(lableAverage);
            Controls.Add(label11);
            Controls.Add(totalLabel);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(englishTextBox);
            Controls.Add(label7);
            Controls.Add(bigDataTextBox);
            Controls.Add(label6);
            Controls.Add(cshapTextBox);
            Controls.Add(label5);
            Controls.Add(pythonTextBox);
            Controls.Add(label4);
            Controls.Add(javaTextBox);
            Controls.Add(label3);
            Controls.Add(nameScoreStudentTextBox);
            Controls.Add(label2);
            Controls.Add(addScoreStudentButton);
            Controls.Add(idScoreStudentTextBox);
            Controls.Add(scoreStudentDataGridView);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 5, 3, 5);
            Name = "ScoreStudentForm";
            Text = "ScoreStudentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)scoreStudentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox idScoreStudentTextBox;
        private DataGridView scoreStudentDataGridView;
        private Button addScoreStudentButton;
        private Label label2;
        private Label label3;
        private TextBox nameScoreStudentTextBox;
        private Label label4;
        private TextBox javaTextBox;
        private Label label5;
        private TextBox pythonTextBox;
        private Label label6;
        private TextBox cshapTextBox;
        private Label label7;
        private TextBox bigDataTextBox;
        private Label label8;
        private TextBox englishTextBox;
        private Label label9;
        private Label totalLabel;
        private Label label11;
        private Label lableAverage;
        private Label label13;
        private Label gradeLabel;
        private Button saveScoreStudentButton;
        private Button updateScoreStudentButton;
        private Button closeButton;
        private Button deleteScoreStudentButton;
    }
}