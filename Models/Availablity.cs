using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Group_Project.Models
{
    public class Availablity
    {
        [Key]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "@{0: yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public string Date { get; set; }

        //public List<string> AvailableDates = new List<string>() { "2021/12/12", "2021/12/13", "2021/12/14", "2021/12/15", "2021/12/16", "2021/12/17", "2021/12/18" };

        //[DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "@{0: yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        // public List<string> NonAvailableDates = new List<string>() { "2021/12/25" };
        
        [DataType(DataType.Time)]
        public int Time { get; set; }


        public static List<int> TimeList() {
            List<int> timeList = new List<int>();
            for (int i = 8; i <= 20; i++)
            {
                timeList.Add(i);
            }
            return timeList;
        }
    }
}
