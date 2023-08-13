using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Features
{
    public class TimeSheetDepartment
    {
        public TimeSheetDbContext DbContext { get; }
        public TimeSheetDepartment()
        {
            DbContext = new TimeSheetDbContext();
        }
        public void AddDepartment(Department department)
        {
            if (string.IsNullOrEmpty(department.Id) ||
               string.IsNullOrEmpty(department.DptName) ||
               string.IsNullOrEmpty(department.DptManager) ||
               string.IsNullOrEmpty(department.DptPrice) ||
               string.IsNullOrEmpty(department.DptPhone))
            {
                throw new ArgumentException("Please provide all department data!");
            }
            else
            {
                DbContext.Departments.Add(department);
                DbContext.SaveChanges();
            }
        }
        public void UpdateDepartment(string Id, string DptName, string DptManager, string DptPrice, string DptPhone)
        {
            if (string.IsNullOrEmpty(DptName) || string.IsNullOrEmpty(DptManager) || string.IsNullOrEmpty(DptPrice)
                || string.IsNullOrEmpty(DptPhone))
            {
                throw new ArgumentException("Please provide all Department data");
            }
            var department = DbContext.Departments.Find(Id);
            if (department == null)
            {
                throw new ArgumentException("Department not found!");
            }
            //update the Department
            department.DptName = DptName;
            department.DptManager = DptManager;
            department.DptPrice = DptPrice;
            department.DptPhone = DptPhone;
            DbContext.SaveChanges();
        }
        public void DeleteDepartment(string Id, string DptName, string DptManager, string DptPrice, string DptPhnoe)
        {
            var d = DbContext.Departments.Find(Id);
            if(d == null)
            {
                throw new ArgumentException("Department not found!");
            }
            DialogResult result = MessageBox.Show("Are you sure to delete this department?", "Delete Department", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DbContext.Departments.Remove(d);
                DbContext.SaveChanges();
            }
            
        }
        public List<Department> GetAllDepartment()
        {
            return DbContext.Departments.Select(department => new Department()
            {
                Id = department.Id,
                DptName = department.DptName,
                DptManager = department.DptManager,
                DptPrice = department.DptPrice,
                DptPhone = department.DptPhone
            }).ToList();
        }
        public List<Department> GetAllDepartment(bool isSimpleVersion)
        {
            return DbContext.Departments.ToList();
        }
    }

}
