using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Reprository.Contract;

namespace WebApi.Reprository.Service
{
    public class EmployeeService:IEmployee
    {
        private readonly ApplicationDbContext dbContext;

        public EmployeeService(ApplicationDbContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public Employee DeleteEmployee(int id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.Id == id);
            if (emp != null)
            {
                dbContext.Employees.Remove(emp);
                dbContext.SaveChanges();
                return emp;
            }
            return null;
        }

        public Employee GetEmployeeById(int id)
        {
            var emp = dbContext.Employees.SingleOrDefault(e => e.Id == id);
            return emp;
        }

        public List<Employee> GetEmployees()
        {
            return dbContext.Employees.ToList();
        }
        
        public Employee PostEmployee(Employee employee)
        {
            dbContext.Employees.Add(employee);
            dbContext.SaveChanges();
            return employee;
        }

        public Employee UpdateEmployee(Employee emp)
        {
            dbContext.Employees.Update(emp);
            dbContext.SaveChanges();
            return emp;

        }
    }
}
