﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Entities
{
    public class Teacher
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public string? Subject { get; set; }
        public string? Saray { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public ICollection<Log>? Logs { get; set; }
        public UserAccount? UserAccount { get; set; }
    }
}
