using LoginPage.Models;
using LoginPage.Service_Business;
using Microsoft.AspNetCore.Mvc;

namespace LoginPage.Controllers
{
    public class AccountController : Controller
    {
        private readonly IRegistration_Services _registration_Services;

        public AccountController(IRegistration_Services registration_Services)
        {
            _registration_Services = registration_Services;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AccountUser(AccounUser accounUser)
        {
            if (ModelState.IsValid)
            {
                _registration_Services.RegisterUser(accounUser);
                return RedirectToAction("Login"); // Redirect to the login page after successful registration
            }
            return View("Index", accounUser);
        }

        [HttpPost]
        public IActionResult Login(AccounUser login)
        {
            // Perform login logic
            if (!_registration_Services.Login(login.Email, login.Password))
            {
                // Login unsuccessful, return to the login page with an error message
                ViewBag.ErrorMessage = "Invalid email or password.";
                return View("Index");
            }
            // Login successful, perform necessary actions
            // For example, redirect the user to another page
            return RedirectToAction("Dashboard", "Home");
        }

    }

}

