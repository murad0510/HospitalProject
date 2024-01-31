using Microsoft.AspNetCore.Mvc;

namespace HospitalProject.WebUI.Controllers
{
    public class AdminController : Controller
    {
        //private CustomIdentityDbContext _customIdenityDbContext;
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Start()
        {
            return View();
        }


        public IActionResult Selected(string selected)
        {
            selected = selected.Trim();
            selected = selected.ToLower();

            return RedirectToAction("Login", "Authentication", new { selected });
        }

        //[HttpPost]
        //public IActionResult Login()
        //{
        //    return View();
        //}


        public IActionResult Activities()
        {
            return View();
        }

        public IActionResult AddApointment()
        {
            return View();
        }

        public IActionResult AddBlog()
        {
            return View();
        }

        public IActionResult AddDepartment()
        {
            return View();
        }

        public IActionResult AddDoctor()
        {
            return View();
        }

        public IActionResult AddPatient()
        {
            return View();
        }

        public IActionResult AddSalary()
        {
            return View();
        }

        public IActionResult AddSchedule()
        {
            return View();
        }

        public IActionResult Appointments()
        {
            return View();
        }

        public IActionResult Attendance()
        {
            return View();
        }

        public IActionResult Calendar()
        {
            return View();
        }

        public IActionResult ChangePassword()
        {
            return View();
        }

        public IActionResult Chat()
        {
            return View();
        }

        public IActionResult Departments()
        {
            return View();
        }

        public IActionResult Doctors()
        {
            return View();
        }

        public IActionResult EditDepartment()
        {
            return View();
        }

        public IActionResult EditDoctor()
        {
            return View();
        }

        public IActionResult EditPatient()
        {
            return View();
        }

        public IActionResult AddProfile()
        {
            return View();
        }

        public IActionResult EditSchedule()
        {
            return View();
        }

        public IActionResult Error404()
        {
            return View();
        }

        public IActionResult Error500()
        {
            return View();
        }

        public IActionResult Patients()
        {
            return View();
        }

        public IActionResult Payments()
        {
            return View();
        }

        public IActionResult Profile()
        {
            return View();
        }

        public IActionResult Schedule()
        {
            return View();
        }

        public IActionResult Settings()
        {
            return View();
        }

    }
}
