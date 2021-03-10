using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Payroll.Entity
{
    public class Employee
    {
        public int ID { get; set; }
        [Required]
        public string EmployeeNo { get; set; }
        [Required, MaxLength(50)]
        public string FirstName { get; set; }
        [Required, MaxLength(50)]
        public string MiddleName { get; set; }
        [Required, MaxLength(50)]
        public string LastName { get; set; }
        [Required, MaxLength(50)]
        public string FullName { get; set; }
        [Required, MaxLength(100)]
        public string Gender { get; set; }
        public string ImageUrl { get; set; }
        public DateTime DOB { get; set; }
        public DateTime DateJoined { get; set; }
        public string PhoneNo { get; set; }
        public string Designation { get; set; }
        public string Email { get; set; }
        [Required, MaxLength(50)]
        public string SSN { get; set; }
        [Required]
        public PaymentMethod PaymentMethod { get; set; }
        public StudentLoan StudentLoan { get; set; }
        public string Address { get; set; }
        [Required, MaxLength(150)]
        public string City { get; set; }
        [Required, MaxLength(50)]
        public string Zipcode { get; set; }
        [Required]
        public IEnumerable<PaymentRecord> PaymentRecords { get; set; }

    }
}
