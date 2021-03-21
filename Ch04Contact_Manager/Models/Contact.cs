using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace Ch04ContactManager.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        [Required(ErrorMessage= "Please enter a first name: ")]
        public string F_Name { get; set; }
        [Required(ErrorMessage = "Please enter a last name: ")]
        public string L_Name { get; set; }
        [Required(ErrorMessage = "Please enter a phone number: ")]
        public string? PhoneNumber { get; set; }
        [Required(ErrorMessage = "Please enter an email address: ")]
        public string? EmailAddress { get; set; }
        public string Organization { get; set; }
        public DateTime DateAdded { get; set; }
        [Range(1,100000000)]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        





    }
}
