using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Group_Project.Models;
using Group_Project.Models.ViewModels;
using System;

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

        public static List<int> TimeList()
        {
            List<int> timeList = new List<int>();
            for (int i = 8; i <= 20; i++)
            {
                timeList.Add(i);
            }
            return timeList;
        }

        [HttpGet]
        //sign up page for picking appointment time from list with available
        public IActionResult SignUp()
        {
            var nowDate = DateTime.Now;

            List<int> timelist = TimeList();
            List<Availablity> availability = new List<Availablity>();
            //list to keep track of of dates already used
            
            for (int i=0; i<=7; i++)
            {
                var tempAvail = new Availablity();
                List<int> tempTime = new List<int>();

                tempAvail.Date = nowDate.AddDays(i).ToString("yyyy-MM-dd");
                var nonAvail = from date in context.Appointments
                               where date.Date == tempAvail.Date
                               select date.Time;
                //add times to the array that are not in the query
                //problem (it doesn't account for more than one occurrence in a date)
                foreach (var query in nonAvail)
                {
                    tempTime.Add(query);
                }
                tempAvail.availTime = tempTime;
                availability.Add(tempAvail);
            }
            ViewBag.availability = availability;
            ViewBag.timelist = timelist;
            return View();
        }


        [HttpPost] //redirect to create apppointment
        public IActionResult SignUp(Availablity availableSelected)
        {
            ViewBag.Date = availableSelected.Date;
            ViewBag.Time = availableSelected.Time;

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
