using Payroll.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Payroll.Services
{
   public interface IEmployeeService
    {
        Task CreateAsync(Employee newEmployee);
        Employee GetByID(int employeeID);
        Task UpdateAsync(Employee employee);
        Task UpdateAsync(int ID);
        Task Delete(int employeeID);
        decimal SLRAmount(int ID, decimal totalAmount);
        IEnumerable<Employee> GetAll();
    }
}
