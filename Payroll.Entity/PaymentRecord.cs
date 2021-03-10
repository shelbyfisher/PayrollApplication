﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Payroll.Entity
{
    public class PaymentRecord
    {
        public int ID {get; set;}
        [ForeignKey("Employee")]
        public int EmployeeID { get; set; }
        public Employee employee { get; set; }
        [MaxLength(100)]
        public string FullName { get; set; }
        public string SSN { get; set; }
        public DateTime PayDate { get; set; }
        public string PayMonth { get; set; }
        [ForeignKey("TaxYear")]
        public int TaxYearID { get; set; }
        public int TaxYear { get; set; }
        public TaxYear taxYear { get; set; }
        public string TaxCode { get; set; }
        [Column(TypeName = "money")]
        public decimal HourlyRate { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal HoursWorked { get; set; }
        [Column(TypeName = "decimal(18, 2)")]
        public decimal OvertimeHours { get; set; }
        [Column(TypeName = "money")]

        public decimal ContractualEarnings { get; set; }
        [Column(TypeName = "money")]

        public decimal OvertimeEarnings { get; set; }
        [Column(TypeName = "money")]

        public decimal Tax { get; set; }
        [Column(TypeName = "money")]

        public decimal SS { get; set; }
        [Column(TypeName = "money")]

        public decimal ContractualHours { get; set; }
        [Column(TypeName = "decimal(18, 2)")]

        public Nullable<decimal> SLC { get; set; }
        [Column(TypeName = "money")]

        public decimal TotalEarnings { get; set; }
        [Column(TypeName = "money")]
        public decimal TotalDeduction { get; set; }
        [Column(TypeName ="money")]
        public decimal NetPayment { get; set; }
    }
}
