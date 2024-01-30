using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities.Entities
{
    public class Salary
    {
        public double Amount { get; set; }
        public Guid? EmployeeId { get; set; }
        public string? PaymentMethod { get; set; }
    }
}
