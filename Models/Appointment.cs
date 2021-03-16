using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Project1.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }
        
        [Required(ErrorMessage ="Please enter the name of the group.")]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }
        
        [Required(ErrorMessage = "Please enter the size of the group as an integer.")]
        [Display(Name = "Group Size")]
        public int GroupSize { get; set; }
        
        [Required(ErrorMessage ="Please enter a valid email address.")]
        [EmailAddress]
        [Display(Name ="Email Address")]
        public  string Email { get; set; }


        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        [Display(Name = "Email Address")]
        public string Phone { get; set; }


        [Required(ErrorMessage ="Time Slot Required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:HH:mm}")]
        [RegularExpression(@"^(?:0?[8-9]|1[1-2]|2[0-9]):[0][0]$", ErrorMessage = "Invalid time.")]
        public DateTime Timeslot { get; set; }

    }
}
