using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Trash_Collector.Models
{
    public class GetDayOfPickupViewModel
    {
        [Required]
        [Display(Name = "Day of the Week")]
        public string dayOfTheWeek { get; set; }
    }
    public class GetBalanceViewModel
    {
        [Required]
        public string balance { get; set; }
    }
}