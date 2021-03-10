using Payroll.Entity;
using PayrollApp.Persistence;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Services.Implementation
{
    public class EmployeeService : IEmployeeService
    {
        private readonly ApplicationDbContext _context;
        public EmployeeService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CreateAsync(Employee newEmployee)
        {
            await _context.employees.AddAsync(newEmployee);
            await _context.SaveChangesAsync();
        }

        public Employee GetByID(int employeeID) =>
            _context.employees.Where(e => e.ID == employeeID).FirstOrDefault();
       

        public async Task Delete(int employeeID)
        {
            var employee = GetByID(employeeID);
            _context.Remove(employee);
            await _context.SaveChangesAsync();
        }

        public IEnumerable<Employee> GetAll() => _context.employees;

        public async Task UpdateAsync(Employee employee)
        {
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int ID)
        {
            var employee = GetByID(ID);
            _context.Update(employee);
            await _context.SaveChangesAsync();
        }



        public decimal SLRAmount(int ID, decimal totalAmount)
        {
            throw new NotImplementedException();
        }

     
    }
}
