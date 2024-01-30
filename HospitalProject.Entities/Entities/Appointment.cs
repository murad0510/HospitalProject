using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalProject.Entities.Entities
{
    public class Appointment
    {
        public int Id { get; set; }
        public string? PatientName { get; set; }
        public int Age { get; set; }
        public string? DoctorName { get; set; }
        public Department? Department { get; set; }
        public DateTime? AppointmentDate { get; set; }
        public int AppointmentTime { get; set; }
        public string? Status { get; set; }
    }
}
