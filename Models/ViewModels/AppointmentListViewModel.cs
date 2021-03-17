using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Project.Models.ViewModels
{
    public class AppointmentListViewModel
    {
        [Key]
        public int Key { get; set; }
        public IEnumerable<Availablity> Availablities { get; set; }
        public DateInfo DateInfo { get; set; }
    }
}
