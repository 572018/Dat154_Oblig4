using BookingSystem.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using BookingSystem.Services;

namespace BookingSystem.Controllers
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

        public IActionResult Login()
        {
            return View();
        }

  
        public IActionResult ProcessLogin(string password, string email)
        {

            Customer model;

           /* if(model == null && ValidatePassword(password, model))
            {
                return View("BookingPage", model);
            }

            ViewData["Message"] = "Email or password not correct/found";*/
            return View();

        
        }

        public IActionResult BookingPage(Customer model)
        {


            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}