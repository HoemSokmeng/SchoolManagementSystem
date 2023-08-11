
using SchoolManagementSystem.Entities;
using SchoolManagementSystem.Features;

namespace SchoolManagementSystem
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            TimeSheet AppTimeSheet = new TimeSheet();
            TimeSheetStudent AppTimeSheet2 = new TimeSheetStudent();
            TimeSheetDepartment AppTimeSheet3 = new TimeSheetDepartment();
            CalculateScore AppTimeSheet4 = new CalculateScore();

            //Seed the data into database if database is empty
            AppTimeSheet.DbContext.Database.EnsureCreated();

            var tch = AppTimeSheet.DbContext.Teachers.FirstOrDefault();
            if (tch == null)
            {
                var aEmp = new Teacher()
                {
                    Id = "001",
                    Name = "Admin",
                    Subject = "Admin",
                    Saray = "001",
                    Address = "Admin",
                    Phone = "000000000",
                    UserAccount = new UserAccount()
                    {
                        UserName = "Admin",
                        Password = "123"
                    }
                };
                AppTimeSheet.DbContext.Teachers.Add(aEmp);
                AppTimeSheet.DbContext.SaveChanges();
            }
            Application.Run(new LoginForm(AppTimeSheet, AppTimeSheet2, AppTimeSheet3, AppTimeSheet4));
        }

    }
}