using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Project.Models
{
    public class EFAppointmentRepository : IAppointmentRepository
    {
        private AppointmentDbContext _context;

        public EFAppointmentRepository (AppointmentDbContext context)
        {
            _context = context;
        }

        public IQueryable<Appointment> Appointments => _context.Appointments;
    }
}
