using System.ComponentModel.DataAnnotations;

namespace HospitalProject.WebUI.Models
{
    public class RegisterViewModel
    {
        ////[Required]
        //public string? UserName { get; set; }

        ////[Required]
        ////[DataType(DataType.EmailAddress)]
        //public string? Email { get; set; }

        ////[Required]
        ////[DataType(DataType.Password)]
        //public string? Password { get; set; }

        ////[Required]
        ////[DataType(DataType.Password)]
        //public string? ConfirmPassword { get; set; }

        ////[Required]
        ////[DataType(DataType.PhoneNumber)]
        //public int MobileNumber { get; set; }

        [Required]
        public string? UserName { get; set; }
        [Required]
        public string? Email { get; set; }
        [DataType(DataType.Password)]
        public string? Password { get; set; }
        [DataType(DataType.Password)]
        public string? ConfirmPassword { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public int MobileNumber { get; set; }
        public string? Selected { get; set; }
    }
}
