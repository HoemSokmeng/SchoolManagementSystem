using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Entities
{
    public class Log
    {
        public int Id { get; set; }
        public DateTime? TimeStamp { get; set; }
        public string? TimeShift { get; set; }

    }

}
