using HospitalProject.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities.Entities
{
    public class Doctor : CustomIdentityUser
    {
        public Guid? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? BirthDate { get; set; }
        public string? Gender { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? Avatar { get; set; }
        public string? Bio { get; set; }
        public int ExperienceYear { get; set; }
        public string? Education { get; set; }
        public string? Status { get; set; }
        public ICollection<Patient>? Patients { get; set; }
        public ICollection<Recipe>? Receipes { get; set; }


    }
}
