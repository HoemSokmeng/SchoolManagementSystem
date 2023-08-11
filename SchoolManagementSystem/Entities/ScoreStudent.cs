using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagementSystem.Entities
{
    public class ScoreStudent
    {
        public string? Id { get; set; }
        public string? Name { get; set; }
        public double Python { get; set; }
        public double Java { get; set; }
        public double CShap { get; set; }
        public double BigData { get; set; }
        public double English { get; set; }
        public double Total { get; set; }
        public double Average { get; set; }
        public String? Grade { get; set; }
    }
}
