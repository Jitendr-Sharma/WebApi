using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Reprository.Contract
{
    public interface IEmployee
    {
        List<Employee> GetEmployees();
        Employee PostEmployee(Employee employee);
        Employee GetEmployeeById(int id);
        Employee DeleteEmployee(int id);
        Employee UpdateEmployee(Employee emp);
      
    }
}
