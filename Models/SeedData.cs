using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Project.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder appointment)
        {
            AppointmentDbContext context = appointment.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<AppointmentDbContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Appointments.Any())
            {
                context.Appointments.AddRange(
                    new Appointment
                    {
                        GroupName = "Wellness",
                        GroupSize = 4,
                        Email = "brianna@gmail.com",
                        Time = 8,
                        Date = "12/12/2020"
                    }
                );

                context.SaveChanges();
            }


        }
    }
}

