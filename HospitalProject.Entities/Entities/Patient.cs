using HospitalProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HospitalProject.Entities.Entities
{
    public class Patient : CustomIdentityUser
    {
        public string? FullName { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public ICollection<string>? Recipes { get; set; }
        public ICollection<Doctor> Doctors { get; set; }
    }
}
