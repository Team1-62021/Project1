using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Group_Project.Models.ViewModels;

namespace Group_Project.Models
{
    public class AppointmentDbContext : DbContext
    {
        public AppointmentDbContext(DbContextOptions<AppointmentDbContext> options) : base(options)
        {

        }

        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Availablity> Availablities { get; set; }
        //public DbSet<DateInfo> DateInfos { get; set; }
        //public DbSet<AppointmentListViewModel> AppointmentListViewModels { get; set; }


    }
}
