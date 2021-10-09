using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebABC.Web.Dto
{
    public class CustomerDto
    {
        [Required]
        public string Name { get; set; }
        public bool Gender { get; set; }
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Email Address Required!")]
        public string Email { get; set; }
        [Required]
        public string Address { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Phone Number Required!")]
        public string PhoneNumber { get; set; }
        public string Note { get; set; }
    }
}
