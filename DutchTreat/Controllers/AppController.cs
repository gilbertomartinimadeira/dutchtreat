using System;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers {

    public class AppController : Controller {

        public IActionResult Index()
        {          

            return View();
        }

        [HttpGet("contact")]
        public IActionResult Contact()
        {
            ViewBag.Title = "Contact Us";
            return View();
        }

        [HttpPost("contact")]
        public IActionResult Contact(ContactViewModel contact)
        {
            ViewBag.Title = "Contact Us";

            if (ModelState.IsValid)
            {
                return RedirectToAction();
            }
            return View(contact);
            
        }

    }
}