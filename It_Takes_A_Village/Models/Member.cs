using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace It_Takes_A_Village.Models
{
    public class Member
    {
        public int MemberId { get; set; }
        [Required(ErrorMessage = "Please enter a first name: ")]
        public string F_Name { get; set; }
        [Required(ErrorMessage = "Please enter a last name: ")]
        public string L_Name { get; set; }
        [Required(ErrorMessage = "Please enter a phone number: ")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter an email address: ")]
        public string? EmailAddress { get; set; }
        public string? Hobby { get; set; }
        public DateTime DateAdded { get; set; }
        public int ProfessionId { get; set; }
        public Profession Job { get; set; }
    }
}
