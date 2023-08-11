﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Entities
{
    public class TimeSheetDbContext : DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<UserAccount> UserAccounts { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<AttenStudent> Attens { get; set; }
        public DbSet<ScoreStudent> ScoreStudents { get; set; }
        public string DbPath { get; }

        public TimeSheetDbContext()
        {
            var folder = Environment.SpecialFolder.MyPictures;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "SchoolManagementSystemDB.db");
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite($"Data Source={DbPath}");
        }
    }

}
