﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagementSystem.Entities;
using Microsoft.EntityFrameworkCore;

namespace SchoolManagementSystem.Features
{
    public class TimeSheet
    {
        public TimeSheetDbContext DbContext { get; }
        public TimeSheet()
        {
            DbContext = new TimeSheetDbContext();
        }
        public void AddTeacher(Teacher teacher)
        {
            if (string.IsNullOrEmpty(teacher.Id) ||
               string.IsNullOrEmpty(teacher.Name) ||
               string.IsNullOrEmpty(teacher.Subject) ||
               string.IsNullOrEmpty(teacher.Saray) ||
               string.IsNullOrEmpty(teacher.Address) ||
               string.IsNullOrEmpty(teacher.Phone) ||
               string.IsNullOrEmpty(teacher.UserAccount.UserName) ||
               string.IsNullOrEmpty(teacher.UserAccount.Password))
            {
                throw new ArgumentException("Please provide all teacher data!");
            }
            else
            {
                DbContext.Teachers.Add(teacher);
                DbContext.SaveChanges();
            }
        }
        public void UpdateTeacher(string TecId, string Name, string Subject, string Salary ,string Address, string Phone)
        {
            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(Subject) || string.IsNullOrEmpty(Salary)
                ||(string.IsNullOrEmpty(Address) || (string.IsNullOrEmpty(Phone))))
            {
                throw new ArgumentException("Please provide all teacher data");
            }
            var teacher = DbContext.Teachers.Find(new string(TecId));
            if (teacher == null)
            {
                throw new ArgumentException("Teacher not found!");
            }
            //update the teacher
            teacher.Name = Name;
            teacher.Subject = Subject;
            teacher.Saray = Salary;
            teacher.Address = Address;
            teacher.Phone = Phone;
            DbContext.SaveChanges();
        }
        public void DeleteTeacher(string Id, string Name, string Subject, string Salary, string Address,
            string Phone, string Username, string Password)
        {
            var t = DbContext.Teachers.Find(Id);
            if(t == null)
            {
                throw new ArgumentException("Teacher not found!");
            }
            DbContext.Teachers.Remove(t);
            DbContext.SaveChanges();
        }
        public void LogTeacher(string id, Log loInfo)
        {
            if (string.IsNullOrEmpty(id))
            {
                throw new ArgumentException("Id No empty!");
            }
            var teacher = DbContext.Teachers.Include(l => l.Logs).FirstOrDefault(teacher => teacher.Id == id.Trim());

            if (teacher == null)
            {
                throw new ArgumentException($"Id {id} not found in Teacher list.");
            }
            teacher.Logs!.Add(loInfo);
            DbContext.SaveChanges();
        }
        public List<TeacherView> GetAllTeacher()
        {
            return DbContext.Teachers.Select(techer => new TeacherView()
            {
                TecId = techer.Id,
                Name = techer.Name,
                Subject = techer.Subject,
                Saray = techer.Saray,
                Address = techer.Address,
                Phone = techer.Phone,
            }).ToList();
        }

        public List<Teacher> GetAllTeacher(bool isSimpleVersion)
        {
            return DbContext.Teachers.ToList();
        }
    }
}
