﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Project.Models
{
    public interface IAppointmentRepository
    {
        IQueryable<Appointment> Appointments { get; }
    }
}