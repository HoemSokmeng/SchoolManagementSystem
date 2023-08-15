using SchoolManagementSystem.Entities;
using SchoolManagementSystem.Features;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagementSystem
{
    public partial class TeacherForm : Form
    {
        TimeSheet timeSheet;
        public TeacherForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
            LoadToGrid();
            // LoadToGrid(true);

            //Disable Update Button
            updateTeacherButton.Enabled = false;
            saveTeacherButton.Enabled = false;
            deleteTeacherButton.Enabled = false;
        }


        private void addTeacherButton_Click(object sender, EventArgs e)
        {
            idTeacherTextBox.Clear();
            nameTeacherTextBox.Clear();
            subjectTeacherTextBox.Clear();
            salaryTeacherTextBox.Clear();
            addressTeacherTextBox.Clear();
            phoneTeacherTextBox.Clear();
            usernameTextBox.Clear();
            passwordTextBox.Clear();
            idTeacherTextBox.Focus();
            saveTeacherButton.Enabled = true;
            updateTeacherButton.Enabled = false;
            deleteTeacherButton.Enabled = false;
        }

        private void saveTeacherButton_Click(object sender, EventArgs e)
        {
            try
            {
                int foundIdex = timeSheet.GetAllTeacher().FindIndex(th => th.TecId == idTeacherTextBox.Text.Trim());
                if (foundIdex == -1)
                {
                    var tch = new Teacher()
                    {
                        Id = idTeacherTextBox.Text.Trim(),
                        Name = nameTeacherTextBox.Text.Trim(),
                        Subject = subjectTeacherTextBox.Text.Trim(),
                        Saray = salaryTeacherTextBox.Text.Trim(),
                        Address = addressTeacherTextBox.Text.Trim(),
                        Phone = phoneTeacherTextBox.Text.Trim(),
                        UserAccount = new UserAccount()
                        {
                            UserName = usernameTextBox.Text.Trim(),
                            Password = passwordTextBox.Text.Trim()
                        }
                    };
                    timeSheet.AddTeacher(tch);
                    LoadToGrid(); //Update the gridview
                }
                else
                {
                    MessageBox.Show($"ID : {idTeacherTextBox.Text.Trim()} is  have already!!");
                }
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addTeacherButton.Enabled = true;
                saveTeacherButton.Enabled = false;
                updateTeacherButton.Enabled = false;
                deleteTeacherButton.Enabled = false;
            }
        }

        private void updateTeacherButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheet.UpdateTeacher(idTeacherTextBox.Text, nameTeacherTextBox.Text, subjectTeacherTextBox.Text, salaryTeacherTextBox.Text, addressTeacherTextBox.Text, phoneTeacherTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addTeacherButton.Enabled = true;
                saveTeacherButton.Enabled = false;
                updateTeacherButton.Enabled = false;
                deleteTeacherButton.Enabled = false;
            }
        }
        private void LoadToGrid()
        {
            TeacherDataGridView.DataSource = timeSheet.GetAllTeacher();
            TeacherDataGridView.Refresh(); //show lastest data
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            TeacherDataGridView.DataSource = timeSheet.GetAllTeacher(isSimpleVersion);
            TeacherDataGridView.Refresh(); //show lastest data
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure wish to quit?", "Exit TeacherForm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }

        }

        private void TeacherDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (TeacherDataGridView.SelectedRows != null && TeacherDataGridView.SelectedRows.Count > 0)
            {
                idTeacherTextBox.Text = TeacherDataGridView.SelectedCells[0].Value.ToString();
                nameTeacherTextBox.Text = TeacherDataGridView.SelectedCells[1].Value.ToString();
                subjectTeacherTextBox.Text = TeacherDataGridView.SelectedCells[2].Value.ToString();
                salaryTeacherTextBox.Text = TeacherDataGridView.SelectedCells[3].Value.ToString();
                addressTeacherTextBox.Text = TeacherDataGridView.SelectedCells[4].Value.ToString();
                phoneTeacherTextBox.Text = TeacherDataGridView.SelectedCells[5].Value.ToString();
                addTeacherButton.Enabled = false;
                saveTeacherButton.Enabled = false;
                updateTeacherButton.Enabled = true;
                deleteTeacherButton.Enabled = true;
            }


        }

        private void deleteTeacherButton_Click(object sender, EventArgs e)
        {
            timeSheet.DeleteTeacher(idTeacherTextBox.Text, nameTeacherTextBox.Text, subjectTeacherTextBox.Text,
                salaryTeacherTextBox.Text, addressTeacherTextBox.Text, phoneTeacherTextBox.Text, usernameTextBox.Text, passwordTextBox.Text);
            LoadToGrid();
            addTeacherButton.Enabled = true;
            saveTeacherButton.Enabled = false;
            updateTeacherButton.Enabled = false;
            deleteTeacherButton.Enabled = false;
        }
    }
}