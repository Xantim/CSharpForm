using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AS_DojoSurvey.Models;

namespace AS_DojoSurvey.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("user")]
        public IActionResult User()
        {
            return View();
        }

        [HttpPost("PostMethod")]
        public IActionResult PostMethod(User newUser)
        {
            // ViewBag.Name = newUser.Name;
            // ViewBag.Email = newUser.Email;
            // ViewBag.Password = newUser.Password;
            // ViewBag.Location = newUser.Location;
            // ViewBag.Language = newUser.Language;
            // ViewBag.Comment = newUser.Comment;
            return View("Success", newUser);
        }

        
    }
}
