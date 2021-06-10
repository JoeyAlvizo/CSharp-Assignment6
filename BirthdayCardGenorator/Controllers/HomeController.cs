using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BirthdayCardGenorator.Models;

namespace BirthdayCardGenorator.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SendCardForm()
        {
            return View(new BirthdayCardRequest());
        }
        [HttpPost]
        public IActionResult SendCardForm(Models.BirthdayCardRequest birthdayCardRequest)
        {
            if(ModelState.IsValid)
            {
                return View("BirthdayCard", birthdayCardRequest);
            }
            else
            {
                return View(birthdayCardRequest);
            }
        }
    }
}
