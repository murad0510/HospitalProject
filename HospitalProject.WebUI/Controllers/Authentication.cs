using HospitalProject.Entities.Entity;
using HospitalProject.WebUI.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace HospitalProject.WebUI.Controllers
{
    public class Authentication : Controller
    {
        private readonly UserManager<CustomIdentityUser> _userManager;
        private readonly RoleManager<CustomIdentityRole> _roleManager;
        private readonly SignInManager<CustomIdentityUser> _signInManager;
        private readonly CustomIdentityDbContext _customIdentityDbContext;

        public Authentication(UserManager<CustomIdentityUser> userManager, RoleManager<CustomIdentityRole> roleManager, SignInManager<CustomIdentityUser> signInManager, CustomIdentityDbContext customIdentityDbContext)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _signInManager = signInManager;
            _customIdentityDbContext = customIdentityDbContext;
        }

        [HttpGet]
        public IActionResult Login(string selected)
        {
            var viewModel = new LoginViewModel();
            viewModel.Selected = selected;
            return View(viewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel loginViewModel)
        {
            //var result = loginViewModel.UserNameOrEmail.EndsWith("@gmail.com");
            //var d=
            //var result = loginViewModel.Email != null ? loginViewModel.Email : loginViewModel.UserName;
            if (ModelState.IsValid)
            {
                var signIn = await _signInManager.PasswordSignInAsync(loginViewModel.UserName, loginViewModel.Password, true, false);
                if (signIn.Succeeded)
                {
                    var user = _customIdentityDbContext.Users.SingleOrDefault(i => i.UserName == loginViewModel.UserName);
                    if (user != null)
                    {
                        _customIdentityDbContext.Update(user);
                        await _customIdentityDbContext.SaveChangesAsync();
                    }
                    return RedirectToAction("Index", "Home");
                }
            }
            return View(loginViewModel);
        }
        public IActionResult Register()
        {
            return View();
        }




        [HttpGet]
        public async Task<IActionResult> Register(string selected)
        {
            var viewModel = new RegisterViewModel();
            viewModel.Selected = selected;
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel)
        {
            if (ModelState.IsValid && registerViewModel.ConfirmPassword == registerViewModel.Password)
            {
                var user = new CustomIdentityUser
                {
                    Email = registerViewModel.Email,
                    UserName = registerViewModel.UserName,
                    PhoneNumber = registerViewModel.MobileNumber.ToString(),
                };

                var result = await _userManager.CreateAsync(user, registerViewModel.Password);
                if (result.Succeeded)
                {
                    if (!await _roleManager.RoleExistsAsync(registerViewModel.Selected))
                    {
                        var role = new CustomIdentityRole
                        {
                            Name = registerViewModel.Selected,
                        };
                        var resul = await _roleManager.CreateAsync(role);
                        if (!resul.Succeeded)
                        {
                            ModelState.AddModelError("", "Error");
                            return View(registerViewModel);
                        }
                    }

                    await _userManager.AddToRoleAsync(user, registerViewModel.Selected);
                    return RedirectToAction("Login", "Authentication");
                }
            }
            return View(registerViewModel);
        }
    }
}
