using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group_Project.Models.ViewModels;

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

        public IQueryable<Availablity> Availablities => _context.Availablities;
        //public IQueryable<AppointmentListViewModel> AppointmentListViewModels => _context.AppointmentListViewModels;
        //public IQueryable<DateInfo> DateInfos => _context.DateInfos;

    }
}
