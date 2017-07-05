using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trash_Collector.Models
{
    public class CheckRouteViewModel
    {
        [Required]
        [Display(Name = "Day of the Week")]
        public string dayOfTheWeek { get; set; }
    }
     
}