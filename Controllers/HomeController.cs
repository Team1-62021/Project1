﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Group_Project.Models;
using Group_Project.Models.ViewModels;

namespace Group_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // private IAppointmentRepository _repository;
        private AppointmentDbContext context { get; set; }

        //Constructor
        public HomeController(ILogger<HomeController> logger, AppointmentDbContext dbcontext)
        {
            _logger = logger;
            // _repository = repository;
            context = dbcontext;
        }

        public IActionResult Index()
        {
            return View();
        }

        

        [HttpGet]
        //sign up page for picking appointment time from list with available
        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost] //redirect to create apppointment
        public IActionResult SignUp(Availablity availableSelected)
        {
            ViewBag.Date = availableSelected.Date;
            ViewBag.Time= availableSelected.Time;

            return View("CreateAppointment");
        }

        //view for creating an appointment form after selecting a time from the Signup view
        [HttpGet]
        public IActionResult CreateAppointment()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateAppointment(Appointment newAppointment)
        {   
            if (ModelState.IsValid)
            {
                context.Appointments.Add(newAppointment);
                context.SaveChanges();

                //update available times
                //context.Availablities.
                return View("Confirmation");
            }
            return View();
        }

        public IActionResult Confirmation()
        {
            return View();
        }

        public IActionResult ViewAppointment()
		{
            return View(context.Appointments);
		}

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
