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
    public partial class AttendentStudentForm : Form
    {
        TimeSheetStudent timeSheetStudent;
        public AttendentStudentForm(TimeSheetStudent timeSheetStudent)
        {
            InitializeComponent();
            this.timeSheetStudent = timeSheetStudent;
        }

        private void timeInStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var log = new AttenStudent() { TimeStamp = DateTime.Now, TimeShift = "Join" };
                timeSheetStudent.LogStudent(attenStudentTextBox.Text, log);
                ShowMessage("Time-In successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimeLabelStudent.Text = DateTime.Now.ToString();
        }

        private void timeOutStudentButton_Click(object sender, EventArgs e)
        {
            try
            {
                var log = new AttenStudent() { TimeStamp = DateTime.Now, TimeShift = "Leave" };
                timeSheetStudent.LogStudent(attenStudentTextBox.Text, log);
                ShowMessage("Time-Out successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }
        }
        private void ShowMessage(string message, bool show)
        {
            if (show)
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(message, "Application Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            attenStudentTextBox.Clear();
            attenStudentTextBox.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure wish to quit?", "Exit AttendentStudentForm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
