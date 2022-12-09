using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UserRegistrationFormwithValidations.Models;

namespace UserRegistrationFormwithValidations.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        public IActionResult SignUp()
        {
            //IEnumerable<SignupViewModel> Genders = new List<SignupViewModel>() 
            //{
            //    new SignupViewModel {Gender="Male"},
            //    new SignupViewModel {Gender="Female"}
            //};
            return View();
        }



        [HttpPost]
        public IActionResult SignUp(SignupViewModel model)
        {

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View();
        }
    }
}