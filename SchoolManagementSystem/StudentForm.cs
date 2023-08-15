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
    public partial class StudentForm : Form
    {
        TimeSheetStudent timeSheetStudent;
        public StudentForm(TimeSheetStudent timeSheetStudent)
        {
            InitializeComponent();
            this.timeSheetStudent = timeSheetStudent;
            LoadToGrid();
            // LoadToGrid(true);

            //Disable Update Button
            updateStudentButton.Enabled = false;
            saveStudentButton.Enabled = false;
            deleteStudentButton.Enabled = false;
        }
        private void addStudentButton_Click(object sender, EventArgs e)
        {
            idStudentTextBox.Clear();
            nameStudentTextBox.Clear();
            sexStudentComBo.Text = string.Empty;
            departmentStudentTextBox.Clear();
            addressStudentTextBox.Clear();
            phoneStudentTextBox.Clear();
            idStudentTextBox.Focus();
            saveStudentButton.Enabled = true;
        }

        private void saveStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                int foundIdex = timeSheetStudent.GetAllStudent().FindIndex(st => st.IdentityId == idStudentTextBox.Text.Trim());
                if (foundIdex == -1)
                {
                    var std = new Student()
                    {
                        Id = idStudentTextBox.Text.Trim(),
                        Name = nameStudentTextBox.Text.Trim(),
                        Sex = sexStudentComBo.Text.Trim(),
                        Department = departmentStudentTextBox.Text.Trim(),
                        Address = addressStudentTextBox.Text.Trim(),
                        Phone = phoneStudentTextBox.Text.Trim(),
                        BirthDay = dateTimePickerStudent.Value.Date,
                    };
                    timeSheetStudent.AddStudent(std);
                    LoadToGrid();
                }
                else
                {
                    MessageBox.Show($"ID : {idStudentTextBox.Text.Trim()} is  have already!!");
                }
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addStudentButton.Enabled = true;
                saveStudentButton.Enabled = false;
                updateStudentButton.Enabled = false;
                deleteStudentButton.Enabled = false;
            }

        }

        private void LoadToGrid()
        {

            studentDataGridView.DataSource = timeSheetStudent.GetAllStudent();
            studentDataGridView.Refresh(); //show lastest data
        }
        private void LoadToGrid(bool isSimpleVersion)
        {
            studentDataGridView.DataSource = timeSheetStudent.GetAllStudent(isSimpleVersion);
            studentDataGridView.Refresh(); //show lastest data
        }


        private void updateStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheetStudent.UpdateStudent(idStudentTextBox.Text, nameStudentTextBox.Text, sexStudentComBo.Text,
                    departmentStudentTextBox.Text, addressStudentTextBox.Text, phoneStudentTextBox.Text, dateTimePickerStudent.Value.Date);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addStudentButton.Enabled = true;
                saveStudentButton.Enabled = true;
                updateStudentButton.Enabled = false;
                deleteStudentButton.Enabled = false;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you  sure to quit?", "Exit StudentForm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void studentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            var date = dateTimePickerStudent.Text;
            if (studentDataGridView.SelectedRows != null && studentDataGridView.SelectedRows.Count > 0)
            {
                idStudentTextBox.Text = studentDataGridView.SelectedCells[0].Value.ToString();
                nameStudentTextBox.Text = studentDataGridView.SelectedCells[1].Value.ToString();
                sexStudentComBo.Text = studentDataGridView.SelectedCells[2].Value.ToString();
                departmentStudentTextBox.Text = studentDataGridView.SelectedCells[3].Value.ToString();
                addressStudentTextBox.Text = studentDataGridView.SelectedCells[4].Value.ToString();
                phoneStudentTextBox.Text = studentDataGridView.SelectedCells[5].Value.ToString();
                date = studentDataGridView.SelectedCells[6].Value.ToString();
                addStudentButton.Enabled = false;
                saveStudentButton.Enabled = false;
                updateStudentButton.Enabled = true;
                deleteStudentButton.Enabled = true;
            }
        }

        private void deleteStudentButton_Click(object sender, EventArgs e)
        {
            timeSheetStudent.DeleteStudent(idStudentTextBox.Text, nameStudentTextBox.Text, sexStudentComBo.Text,
                departmentStudentTextBox.Text, addressStudentTextBox.Text, phoneStudentTextBox.Text, dateTimePickerStudent.Value);
            LoadToGrid();
            addStudentButton.Enabled = true;
            saveStudentButton.Enabled = false;
            updateStudentButton.Enabled = false;
            deleteStudentButton.Enabled = false;
        }
    }
}