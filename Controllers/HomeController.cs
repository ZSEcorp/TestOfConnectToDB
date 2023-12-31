using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using PandoraCaseTest.Models;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace PandoraCaseTest.Controllers
{
    public class HomeController : Controller
    {
        private IUserRepository repository;
        public HomeController(IUserRepository repo)
        {
            repository = repo;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register() => View();
        [HttpPost]
        public IActionResult Register(User user)
        {
            repository.AddUser(user);
            return View("Succes_register", user);
        }
        [HttpGet]
        public IActionResult Login() => View();
        [HttpPost]
        public IActionResult Login(User user) => repository.ExistUser(user) == true ? View("Succes_login", user) : View();

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}