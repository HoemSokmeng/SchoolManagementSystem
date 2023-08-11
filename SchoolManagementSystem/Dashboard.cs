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
    public partial class Dashboard : Form
    {
        private TimeSheet _timeSheet;
        private TimeSheetStudent _timeSheetStudent;
        private TimeSheetDepartment _timeSheetDepartment;
        private CalculateScore _calculateScore;
        public Dashboard(TimeSheet timeSheet, TimeSheetStudent timeSheetStudent, TimeSheetDepartment timeSheetDepartment, CalculateScore calculateScore)
        {
            InitializeComponent();
            _timeSheet = timeSheet;
            _timeSheetStudent = timeSheetStudent;
            _timeSheetDepartment = timeSheetDepartment;
            _calculateScore = calculateScore;
        }


        private void departmentPictureBox_Click(object sender, EventArgs e)
        {
            DepartmentForm Dpt = new DepartmentForm(_timeSheetDepartment);
            Dpt.ShowDialog();
        }

        private void teacherPictureBox_Click(object sender, EventArgs e)
        {
            TeacherForm tfm = new TeacherForm(_timeSheet);
            tfm.ShowDialog();
        }

        private void studentPictureBox_Click(object sender, EventArgs e)
        {
            StudentForm sfm = new StudentForm(_timeSheetStudent);
            sfm.ShowDialog();

        }

        private void attendentTeacherPictureBox_Click(object sender, EventArgs e)
        {
            AttendentTeacherForm ath = new AttendentTeacherForm(_timeSheet);
            ath.ShowDialog();

        }

        private void attendentStudentPictureBox_Click(object sender, EventArgs e)
        {
            AttendentStudentForm sta = new AttendentStudentForm(_timeSheetStudent);
            sta.ShowDialog();
        }

        private void scoreStudentPictureBox_Click(object sender, EventArgs e)
        {
            ScoreStudentForm sStd = new ScoreStudentForm(_calculateScore);
            sStd.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure wish to quit?", "Exit Dashboard", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }

        }
    }
}
