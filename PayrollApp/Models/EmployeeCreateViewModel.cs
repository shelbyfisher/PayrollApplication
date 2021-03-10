using Microsoft.AspNetCore.Http;
using Payroll.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PayrollApp.Models
{
    public class EmployeeCreateViewModel
    {
        public int ID { get; set; }
        [Required(ErrorMessage ="Employee number is required"),
            RegularExpression(@"^[A-Z]{3,3}[0-9]{3}$")]
        public string EmployeeNo { get; set; }
        [Required(ErrorMessage ="First Name is required"), StringLength(50, MinimumLength =2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name ="First Name")]
        public string FirstName { get; set; }
        [StringLength(50), Display(Name ="Middle Name")]
        public string MiddleName { get; set; }
        [Required(ErrorMessage = "Last Name is required"), StringLength(50, MinimumLength = 2)]
        [RegularExpression(@"^[A-Z][a-zA-Z""'\s-]*$"), Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string FullName {
            get {
                return FirstName + (string.IsNullOrEmpty(MiddleName) ? " " : 
                    (" " + (char?)MiddleName[0] + ".").ToUpper() + LastName);
            }
        }
        
        public string Gender { get; set; }
        [Display(Name ="Photo")]
        public IFormFile ImageUrl { get; set; }
        [DataType(DataType.Date), Display(Name ="Date of birth")]
        public DateTime DOB { get; set; }
        [DataType(DataType.Date), Display(Name = "Date joined")]
        public DateTime DateJoined { get; set; } = DateTime.UtcNow;
        public string PhoneNo { get; set; }
        [Required(ErrorMessage ="Job role is required"), StringLength(100)]
        public string Designation { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, StringLength(50), Display(Name ="Social Ssecurity No.")]
        [RegularExpression(@"^\d{3}-\d{2}-\d{4}$")]
        public string SSN { get; set; }
        [Display(Name ="Payment method")]
        public PaymentMethod PaymentMethod { get; set; }
        [Display(Name = "Student loan")]
        public StudentLoan StudentLoan { get; set; }
        [Required, StringLength(150)]
        public string Address { get; set; }
        [Required, StringLength(50)]
        public string City { get; set; }
        [Required, StringLength(50), Display(Name ="Zip code")]
        public string Zipcode { get; set; }
    }
}
