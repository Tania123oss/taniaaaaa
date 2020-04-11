using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace lab_task_09.Models
{
    public class Register
    {
        [Display(Name = "Username")]
        [Required(ErrorMessage = "Username is Required")]
        public string UserName { get; set; }


        [Display(Name = "Password")]
        [Required(ErrorMessage = "Password is Required")]
        public string password { get; set; }


        [Display(Name = "Confirm Password")]
        [Required(ErrorMessage = "Password is Required")]
        public string ConfirmPassword { get; set; }


        [Display(Name = "Real Name")]
        [Required(ErrorMessage = "Real Name is Required")]
        public string RealName { get; set; }


        [Display(Name = "Date Of birth")]
        [DataType(DataType.Date)]
        public DateTime? DOB { get; set; }


        [Display(Name = "E-Mail")]
        [Required(ErrorMessage = "Email is Required")]
        public string Email { get; set; }


        [Display(Name = "SSN")]
        [Required(ErrorMessage = "Please Enter SSN ")]
        [RegularExpression(@"^\d{9}|\d{3}-\d{2}-\d{4}$", ErrorMessage = "Invalid Social Security Number")]
        public string SSN { get; set; }


        [Display(Name = "Phone")]

        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Please Enter phone number")]
        [RegularExpression(@"^[\d]{4}-[\d]{7}$", ErrorMessage = "Invalid phone number")]
        public string Phone { get; set; }


        [Display(Name = "Zip code")]
        [Required(ErrorMessage = "Please Enter ZipCode")]
        [RegularExpression(@"^\d{5}(-\d{4})?$", ErrorMessage = "Invalid Zip")]
        public string ZipCode { get; set; }


        [Display(Name = "I accept terms")]
        [Range(typeof(bool), "true", "true", ErrorMessage = "You have to accept the terms")]
        public bool TermsAndCondition { get; set; }

    }
}