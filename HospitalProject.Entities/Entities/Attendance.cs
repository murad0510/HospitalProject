using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities.Entities
{
    public class Attendance
    {
        public ICollection<string>? EmployeeNames { get; set; }
        public ICollection<int>? Day { get; set; }
        public bool Active { get; set; }
        public bool Unactive { get; set; }
    }
}
