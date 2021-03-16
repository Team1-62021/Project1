using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Project.Models
{
    public class Appointment
    {
        [Key]
        public int AppointmentId { get; set; }

        [Required(ErrorMessage = "Please enter the name of the group.")]
        [Display(Name = "Group Name")]
        public string GroupName { get; set; }

        [Required(ErrorMessage = "Please enter the size of the group as an integer.")]
        [Display(Name = "Group Size")]
        public int GroupSize { get; set; }

        [Required(ErrorMessage = "Please enter a valid email address.")]
        [EmailAddress]
        [Display(Name = "Email Address")]
        public string Email { get; set; }


        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Please enter a valid phone number")]
        [Display(Name = "Email Address")]
        public string Phone { get; set; }


        
        [Range(8,20)]
        [Required(ErrorMessage = "Please select an appointment time")]
        [DataType(DataType.Time)]
        [DisplayFormat(DataFormatString = "@{0: HH}", ApplyFormatInEditMode = true)]
        [Display(Name = "Appointment Time")]
        public int Time { get; set; }

        //[DataType(DataType.Time)]
        //[Range(typeof(TimeSpan), "8", "20")]
        //[DisplayFormat(DataFormatString = "{0:HH}")]

        [Required(ErrorMessage = "Please enter the appointment date.")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "@{0: dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Display (Name = "Appointment Date")]
        public string Date { get; set; }
    }
}
