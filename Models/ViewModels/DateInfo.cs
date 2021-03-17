using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Project.Models.ViewModels
{
    public class DateInfo
    {
        [Key]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "@{0: yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public string Date { get; set; }
        public int Time { get; set; }
    }
}
