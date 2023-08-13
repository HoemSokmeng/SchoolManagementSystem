using SchoolManagementSystem.Features;
using SchoolManagementSystem.Entities;
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
    public partial class AttendentTeacherForm : Form
    {
        TimeSheet timeSheet;
        public AttendentTeacherForm(TimeSheet timeSheet)
        {
            InitializeComponent();
            this.timeSheet = timeSheet;
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            currentTimeLabel.Text = DateTime.Now.ToString();
        }

        private void timeInTeacherButton_Click(object sender, EventArgs e)
        {
            try
            {
                var atten = new Log() { TimeStamp = DateTime.Now, TimeShift = "Join" };
                timeSheet.LogTeacher(idTeacherTextBox.Text, atten);
                ShowMessage("Time-in Successfully!", true);
            }
            catch (ArgumentException Ec)
            {
                ShowMessage(Ec.Message, false);
            }


        }

        private void timeOutTeacherButton_Click(object sender, EventArgs e)
        {
            try
            {
                var atten = new Log() { TimeStamp = DateTime.Now, TimeShift = "Leave" };
                timeSheet.LogTeacher(idTeacherTextBox.Text, atten);
                ShowMessage("Time-Out Successfully!", true);
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
            idTeacherTextBox.Clear();
            idTeacherTextBox.Focus();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure wish to quit?", "Exit AttendentTeacherForm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
