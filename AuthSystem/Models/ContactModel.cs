using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AuthSystem.Models
{
    public class ContactModel
    {
        public int ID { get; set; }

        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "first name required")]
        public string FirstName { get; set; }


        [Display(Name = "LastName")]
        [Required(ErrorMessage = "last name required")]
        public string LastName { get; set; }


        [Display(Name = "EmailAddress")]
        [Required(ErrorMessage = "Email Address is required")]
        public string EmailAddress { get; set; }


        [Display(Name = "Message")]
        [Required(ErrorMessage = "Subject is required")]
        public string Subject { get; set; }
    }
}
