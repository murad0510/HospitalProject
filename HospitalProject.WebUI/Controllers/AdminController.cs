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


    }
}
