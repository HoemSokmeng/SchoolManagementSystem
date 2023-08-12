using SchoolManagementSystem.Features;
namespace SchoolManagementSystem
{
    public partial class LoginForm : Form
    {
        private TimeSheet _timeSheet;
        private TimeSheetStudent _timeSheetStudent;
        private TimeSheetDepartment _timeSheetDepartment;
        private CalculateScore _calculateScore;
        public LoginForm(TimeSheet timeSheet, TimeSheetStudent timeSheetStudent, TimeSheetDepartment timeSheetDepartment, CalculateScore calculateScore)
        {
            InitializeComponent();
            _timeSheet = timeSheet;
            _timeSheetStudent = timeSheetStudent;
            _timeSheetDepartment = timeSheetDepartment;
            _calculateScore = calculateScore;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var name = usernameTextBox.Text.Trim();
            var passw = passwordTextBox.Text.Trim();
            Authentication auth = new Authentication(_timeSheet.DbContext, name, passw);
            try
            {
                bool result = auth.ValidateLogin();
                if (result)//Login Succeassfully
                {
                    this.Hide();
                    Dashboard dab = new Dashboard(_timeSheet, _timeSheetStudent, _timeSheetDepartment, _calculateScore);
                    dab.Show();
                }
                else
                {
                    MessageBox.Show("Incorrect usename or password");
                }
            }
            catch (ArgumentException Ae)
            {
                MessageBox.Show(Ae.Message);
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure wish to quit?", "Exit Application", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }



        private void passwordTextBox_Click(object sender, EventArgs e)
        {

        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}