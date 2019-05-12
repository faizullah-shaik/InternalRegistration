using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InternRegistration_MVC.Models
{
    public class Class1
    {
        [Required(ErrorMessage = "First name is required.")] public string FirstName { get; set; }
        [Required(ErrorMessage = "Last name is required.")] public string LastName { get; set; }
        [Required(ErrorMessage = "EmpId  is required.")] public string EmpId { get; set; }
        [EmailAddress]
        public string EmailId  { get; set; }
        public string CollegeName { get; set; }
        public string Specialization { get; set; }
        public string[] SkillSet { get; set; }
        public string Gender { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City_Town { get; set; }
        public string State { get; set; }
      
        public string Contact { get; set; }
        public string DateOfBirth { get; set; }
        public string PinCode { get; set; }
       public string Photo { get; set; }

    }
}