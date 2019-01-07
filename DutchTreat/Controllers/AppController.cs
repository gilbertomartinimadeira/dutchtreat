using System;
using DutchTreat.Services;
using DutchTreat.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace DutchTreat.Controllers {

    public class AppController : Controller {
        private IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }

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
        public IActionResult Contact(ContactViewModel contactVM)
        {
            ViewBag.Title = "Contact Us";

            if (ModelState.IsValid)
            {            
                //Send the email
                _mailService.SendMessage("gilberto@email.com", contactVM.Subject, $"From: {contactVM.Name} - {contactVM.Email} , Message: {contactVM.Message}");
                ViewBag.UserMessage = "Mail Sent";               
            }                   
            return View();
            
        }

    }
}