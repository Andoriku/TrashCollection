using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trash_Collector.Models
{
    public class GetRoutesViewModel
    {
        [Required]
        [Display(Name = "Today's Route")]
        public string todaysRoute { get; set; }

        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(GroupName = "Address", Name = "Address Line 1")]
        public string addressLine1 { get; set; }

        [Display(GroupName = "Address", Name = "Address Line 2")]
        public string addressLine2 { get; set; }

        [Display(GroupName = "Address", Name = "City")]
        public string city { get; set; }

        [Display(GroupName = "Address", Name = "State")]
        public string state { get; set; }

        [Display(GroupName = "Address", Name = "Zipcode")]
        public int zipcode { get; set; }
    }
    public class LogDayViewModel
    {
        [Required]
        [Display(Name = "Day for the Route you've just completed")]
        public string dayToLog { get; set; }
    }

}