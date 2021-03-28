using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Ctrlr.Models;
using Microsoft.AspNetCore.Http;

namespace Ctrlr.Controllers
{
    public class HomeController : Controller
    {
        public static List<User> users = new List<User>()
        {
            new User(){UserID=1,UserName="Admin",Password="123",RoleID="1"}
        };
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

        [HttpPost]
        public IActionResult Login(User user)
        {
            if (user == null)
            {
                return RedirectToAction("Login"); 
            }

            if (LoginCheck(user) == null)
            {
                return RedirectToAction("Login"); 
            }

            AddUserToSession(LoginCheck(user));

            return RedirectToAction("Index");
        }
        User LoginCheck(User user)
        {
            foreach (var item in users)
            {
                if (user.UserName == item.UserName && user.Password == item.Password)
                {
                    return item;
                }
            }
            return null;
        }
        void AddUserToSession(User user){
            HttpContext.Session.SetString("Username",user.UserName);
            HttpContext.Session.SetString("RoleId",user.RoleID.ToString());
        }  

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
