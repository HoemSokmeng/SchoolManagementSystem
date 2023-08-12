namespace SchoolManagementSystem
{
    partial class DepartmentForm
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
            idDepartmentTextBox = new TextBox();
            addNewDepartmentButton = new Button();
            label2 = new Label();
            label3 = new Label();
            departmentNameTextBox = new TextBox();
            label4 = new Label();
            departmentManagerTextBox = new TextBox();
            label5 = new Label();
            departmentPriceTextBox = new TextBox();
            saveDepartmentButton = new Button();
            updateDepartmentButton = new Button();
            closeDepartmentButton = new Button();
            departmentDataGridView = new DataGridView();
            label6 = new Label();
            departmentPhoneTextBox = new TextBox();
            deleteDepartmentButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)departmentDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1114, 108);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(128, 128, 255);
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(414, 26);
            label1.Name = "label1";
            label1.Size = new Size(232, 50);
            label1.TabIndex = 0;
            label1.Text = "Department";
            // 
            // idDepartmentTextBox
            // 
            idDepartmentTextBox.Location = new Point(289, 162);
            idDepartmentTextBox.Name = "idDepartmentTextBox";
            idDepartmentTextBox.Size = new Size(225, 39);
            idDepartmentTextBox.TabIndex = 1;
            // 
            // addNewDepartmentButton
            // 
            addNewDepartmentButton.Location = new Point(110, 350);
            addNewDepartmentButton.Name = "addNewDepartmentButton";
            addNewDepartmentButton.Size = new Size(155, 54);
            addNewDepartmentButton.TabIndex = 2;
            addNewDepartmentButton.Text = "Add New";
            addNewDepartmentButton.UseVisualStyleBackColor = true;
            addNewDepartmentButton.Click += addNewDepartmentButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(77, 165);
            label2.Name = "label2";
            label2.Size = new Size(177, 32);
            label2.TabIndex = 1;
            label2.Text = "Department ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 230);
            label3.Name = "label3";
            label3.Size = new Size(218, 32);
            label3.TabIndex = 3;
            label3.Text = "Department Name:";
            // 
            // departmentNameTextBox
            // 
            departmentNameTextBox.Location = new Point(289, 227);
            departmentNameTextBox.Name = "departmentNameTextBox";
            departmentNameTextBox.Size = new Size(225, 39);
            departmentNameTextBox.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(545, 160);
            label4.Name = "label4";
            label4.Size = new Size(249, 32);
            label4.TabIndex = 5;
            label4.Text = "Department Manager:";
            // 
            // departmentManagerTextBox
            // 
            departmentManagerTextBox.Location = new Point(840, 157);
            departmentManagerTextBox.Name = "departmentManagerTextBox";
            departmentManagerTextBox.Size = new Size(225, 39);
            departmentManagerTextBox.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(603, 227);
            label5.Name = "label5";
            label5.Size = new Size(197, 32);
            label5.TabIndex = 7;
            label5.Text = "Deparment Price:";
            // 
            // departmentPriceTextBox
            // 
            departmentPriceTextBox.Location = new Point(840, 224);
            departmentPriceTextBox.Name = "departmentPriceTextBox";
            departmentPriceTextBox.Size = new Size(225, 39);
            departmentPriceTextBox.TabIndex = 8;
            // 
            // saveDepartmentButton
            // 
            saveDepartmentButton.Location = new Point(289, 350);
            saveDepartmentButton.Name = "saveDepartmentButton";
            saveDepartmentButton.Size = new Size(138, 54);
            saveDepartmentButton.TabIndex = 9;
            saveDepartmentButton.Text = "Save";
            saveDepartmentButton.UseVisualStyleBackColor = true;
            saveDepartmentButton.Click += saveDepartmentButton_Click;
            // 
            // updateDepartmentButton
            // 
            updateDepartmentButton.Location = new Point(458, 350);
            updateDepartmentButton.Name = "updateDepartmentButton";
            updateDepartmentButton.Size = new Size(155, 54);
            updateDepartmentButton.TabIndex = 10;
            updateDepartmentButton.Text = "Update";
            updateDepartmentButton.UseVisualStyleBackColor = true;
            updateDepartmentButton.Click += updateDepartmentButton_Click;
            // 
            // closeDepartmentButton
            // 
            closeDepartmentButton.Location = new Point(807, 350);
            closeDepartmentButton.Name = "closeDepartmentButton";
            closeDepartmentButton.Size = new Size(112, 54);
            closeDepartmentButton.TabIndex = 11;
            closeDepartmentButton.Text = "Close";
            closeDepartmentButton.UseVisualStyleBackColor = true;
            closeDepartmentButton.Click += closeDepartmentButton_Click;
            // 
            // departmentDataGridView
            // 
            departmentDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            departmentDataGridView.Location = new Point(87, 410);
            departmentDataGridView.Name = "departmentDataGridView";
            departmentDataGridView.RowHeadersWidth = 62;
            departmentDataGridView.RowTemplate.Height = 33;
            departmentDataGridView.Size = new Size(920, 262);
            departmentDataGridView.TabIndex = 12;
            departmentDataGridView.SelectionChanged += departmentDataGridView_SelectionChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(25, 298);
            label6.Name = "label6";
            label6.Size = new Size(222, 32);
            label6.TabIndex = 13;
            label6.Text = "Department Phone:";
            // 
            // departmentPhoneTextBox
            // 
            departmentPhoneTextBox.Location = new Point(289, 295);
            departmentPhoneTextBox.Name = "departmentPhoneTextBox";
            departmentPhoneTextBox.Size = new Size(225, 39);
            departmentPhoneTextBox.TabIndex = 14;
            // 
            // deleteDepartmentButton
            // 
            deleteDepartmentButton.Location = new Point(640, 350);
            deleteDepartmentButton.Name = "deleteDepartmentButton";
            deleteDepartmentButton.Size = new Size(138, 54);
            deleteDepartmentButton.TabIndex = 15;
            deleteDepartmentButton.Text = "Delete";
            deleteDepartmentButton.UseVisualStyleBackColor = true;
            deleteDepartmentButton.Click += deleteDepartmentButton_Click;
            // 
            // DepartmentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 31F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1113, 696);
            Controls.Add(deleteDepartmentButton);
            Controls.Add(label6);
            Controls.Add(departmentPhoneTextBox);
            Controls.Add(departmentDataGridView);
            Controls.Add(closeDepartmentButton);
            Controls.Add(updateDepartmentButton);
            Controls.Add(saveDepartmentButton);
            Controls.Add(label5);
            Controls.Add(departmentPriceTextBox);
            Controls.Add(label4);
            Controls.Add(departmentManagerTextBox);
            Controls.Add(label3);
            Controls.Add(departmentNameTextBox);
            Controls.Add(label2);
            Controls.Add(idDepartmentTextBox);
            Controls.Add(addNewDepartmentButton);
            Controls.Add(panel1);
            Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 5, 4, 5);
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "DepartmentForm";
            Text = "DepartmentForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)departmentDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox idDepartmentTextBox;
        private Button addNewDepartmentButton;
        private Label label2;
        private Label label3;
        private TextBox departmentNameTextBox;
        private Label label4;
        private TextBox departmentManagerTextBox;
        private Label label5;
        private TextBox departmentPriceTextBox;
        private Button saveDepartmentButton;
        private Button updateDepartmentButton;
        private Button closeDepartmentButton;
        private DataGridView departmentDataGridView;
        private Label label6;
        private TextBox departmentPhoneTextBox;
        private Button deleteDepartmentButton;
    }
}