using EM.Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace EmployeeManagement.Service
{
    public class EmployeeService
    {
        private readonly EmployeeDBContext _dbContext;
        public EmployeeService(EmployeeDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<int> InsertEmployee(Employee employee)
        {
            int returnVal = 0;
            _dbContext.Employee.Add(employee);
            returnVal = _dbContext.SaveChanges();
            return returnVal;
        }

        public List<Employee> GetEmployees()
        {
            return _dbContext.Employee.ToList();
        }

        public int DeleteEmployee(int id)
        {
            int returnVal = 0;
            var data = _dbContext.Employee.Where(a => a.EmployeeId == id).FirstOrDefault();
            _dbContext.Employee.Remove(data);
            _dbContext.SaveChanges();
            return returnVal;
        }

        public void UpdateEmployee(Employee employee)
        {
            _dbContext.Employee.Update(employee);
            _dbContext.SaveChanges();
        }
    }

}
