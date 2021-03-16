using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class EFAppointmentRepository: IAppointmentRepository
    {
        public AppointmentDbContext _context;

        //constructor
        public  EFAppointmentRepository (AppointmentDbContext context)
        {
            _context = context;
        }

        public IQueryable<Appointment> Appointments => _context.Appointments;
    }
}
