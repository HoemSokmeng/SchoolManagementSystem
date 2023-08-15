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
    public partial class DepartmentForm : Form
    {
        TimeSheetDepartment timeSheetDepartment;
        public DepartmentForm(TimeSheetDepartment timeSheetDepartment)
        {
            InitializeComponent();
            this.timeSheetDepartment = timeSheetDepartment;
            LoadToGrid();
            // LoadToGrid(true);

            //Disable Update Button
            updateDepartmentButton.Enabled = false;
            saveDepartmentButton.Enabled = false;
            deleteDepartmentButton.Enabled=false;
        }

        private void addNewDepartmentButton_Click(object sender, EventArgs e)
        {
            idDepartmentTextBox.Clear();
            departmentNameTextBox.Clear();
            departmentManagerTextBox.Clear();
            departmentPriceTextBox.Clear();
            departmentPhoneTextBox.Clear();
            idDepartmentTextBox.Focus();
            saveDepartmentButton.Enabled = true;
        }

        private void saveDepartmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                int foundIdex = timeSheetDepartment.GetAllDepartment().FindIndex(dt => dt.Id == idDepartmentTextBox.Text.Trim());
                if (foundIdex == -1)
                {
                    var dpt = new Department()
                    {
                        Id = idDepartmentTextBox.Text.Trim(),
                        DptName = departmentNameTextBox.Text.Trim(),
                        DptManager = departmentManagerTextBox.Text.Trim(),
                        DptPrice = departmentPriceTextBox.Text.Trim(),
                        DptPhone = departmentPhoneTextBox.Text.Trim()
                    };
                    timeSheetDepartment.AddDepartment(dpt);
                    LoadToGrid();
                }
                else
                {
                    MessageBox.Show($"ID : {idDepartmentTextBox.Text.Trim()} is  have already!!");
                }

            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addNewDepartmentButton.Enabled = true;
                saveDepartmentButton.Enabled = false;
            }
        }

        private void LoadToGrid()
        {
            departmentDataGridView.DataSource = timeSheetDepartment.GetAllDepartment();
            departmentDataGridView.Refresh(); //show lastest data
        }
        private void LoadToGrid(bool isSimpleVersion)
        {

            departmentDataGridView.DataSource = timeSheetDepartment.GetAllDepartment(isSimpleVersion);
            departmentDataGridView.Refresh(); //show lastest data
        }

        private void updateDepartmentButton_Click(object sender, EventArgs e)
        {
            try
            {
                timeSheetDepartment.UpdateDepartment(idDepartmentTextBox.Text, departmentNameTextBox.Text, departmentManagerTextBox.Text,
                                                     departmentPriceTextBox.Text, departmentPhoneTextBox.Text);
                LoadToGrid();
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
            finally
            {
                addNewDepartmentButton.Enabled = true;
                saveDepartmentButton.Enabled = true;
                updateDepartmentButton.Enabled = false;
                deleteDepartmentButton.Enabled = false;
            }
        }

        private void closeDepartmentButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure wish to quit?", "Exit DepartmentForm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void departmentDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (departmentDataGridView.SelectedRows != null && departmentDataGridView.SelectedRows.Count > 0)
            {
                idDepartmentTextBox.Text = departmentDataGridView.SelectedCells[0].Value.ToString();
                departmentNameTextBox.Text = departmentDataGridView.SelectedCells[1].Value.ToString();
                departmentManagerTextBox.Text = departmentDataGridView.SelectedCells[2].Value.ToString();
                departmentPriceTextBox.Text = departmentDataGridView.SelectedCells[3].Value.ToString();
                departmentPhoneTextBox.Text = departmentDataGridView.SelectedCells[4].Value.ToString();
                addNewDepartmentButton.Enabled = false;
                saveDepartmentButton.Enabled = false;
                updateDepartmentButton.Enabled = true;
                deleteDepartmentButton.Enabled = true;
            }

        }

        private void deleteDepartmentButton_Click(object sender, EventArgs e)
        {
            timeSheetDepartment.DeleteDepartment(idDepartmentTextBox.Text, departmentNameTextBox.Text,
                departmentManagerTextBox.Text, departmentPriceTextBox.Text, departmentPhoneTextBox.Text);
            LoadToGrid();
            addNewDepartmentButton.Enabled = true;
            saveDepartmentButton.Enabled = false;
            updateDepartmentButton.Enabled = false;
            deleteDepartmentButton.Enabled = false;
        }
    }
}
