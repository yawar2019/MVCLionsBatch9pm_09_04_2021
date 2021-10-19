using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCLionsBatch9pm_09_04_2021.Models
{
    public class RegistrationModel
    {
        public int UserId { get; set; }
        [Required(ErrorMessage ="UserName Must Not Be Empty!")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password Must Not Be Empty!")]
        public string Password { get; set; }
        [Compare("Password",ErrorMessage ="Password and ConfirmPassword are not same")]
        public string ConfirmPassword { get; set; }
        [Range(18,45,ErrorMessage ="age must be between 18-45")]
        public int age { get; set; }
        [Required(ErrorMessage = "EmailAddress Must Not Be Empty!")]
        [DataType(DataType.EmailAddress)]
        public string EmailId { get; set; }
        [StringLength(10,ErrorMessage ="cannot be more then 10 characters")]
        
        public string Address { get; set; }
    }
}