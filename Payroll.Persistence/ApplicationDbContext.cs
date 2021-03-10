using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Payroll.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace PayrollApp.Persistence

{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<PaymentRecord> paymentRecords { get; set; }
        public DbSet<Employee> employees { get; set; }
        public DbSet<TaxYear> taxYears { get; set; }
    }
}
