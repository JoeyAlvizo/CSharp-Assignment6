using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BirthdayCardGenorator.Models
{
    public class BirthdayCardRequest
    {
        [Required(ErrorMessage = "Please enter From who")]
        public string From { get; set; }
        [Required(ErrorMessage = "Please enter To who")]
        public string To { get; set; }
        [Required(ErrorMessage = "Please enter a Message")]
        public string Message { get; set; }
    }
}
