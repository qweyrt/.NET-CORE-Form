using System;
using Microsoft.AspNetCore.Mvc;
using Ctrlr.Models;
namespace Ctrlr.Controllers
{
    public class MemberController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details()
        {
            Member member = new Member()
            {
                firstname = "Hai",
                lastname = "Nguyen",
                gender = 1,
                dateofbirth = new DateTime(2011, 3, 12),
                phonenumber = 16,
                age = 12,
                placeofbirth = "Ha Noi",
                grad = true,
                startdate = new DateTime(2021, 3, 12),
                enddate = new DateTime(2021, 6, 12)
            };
            return View(member);
        }    
    }
}

