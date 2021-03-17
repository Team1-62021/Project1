using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group_Project.Models.ViewModels;

namespace Group_Project.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }
        IQueryable<Availablity> Availablities { get; }
        //IQueryable<AppointmentListViewModel> AppointmentListViewModels { get; }
        //IQueryable<DateInfo> DateInfos { get; }

    }
}
