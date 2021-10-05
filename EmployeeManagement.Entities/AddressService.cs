using EM.Entities.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;

namespace EmployeeManagement.Service
{
    public class AddressService
    {
        private readonly EmployeeDBContext _dbContext;
        public AddressService(EmployeeDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        public async Task<int> InsertUKEmployee(Ukemployee ukemployee)
        {
            int returnVal = 0;
            _dbContext.UkEmployee.Add(ukemployee);
            returnVal = _dbContext.SaveChanges();
            return returnVal;
        }

        public List<Ukemployee> GetUKEmployees()
        {
            return _dbContext.UkEmployee.ToList();
        }

        public int DeleteUKEmployee(int id)
        {
            int returnVal = 0;
            var data = _dbContext.UkEmployee.Where(a => a.EmployeeId == id).FirstOrDefault();
            _dbContext.UkEmployee.Remove(data);
            _dbContext.SaveChanges();
            return returnVal;
        }

        public void UpdateUKEmployee(Ukemployee ukemployee)
        {
            _dbContext.UkEmployee.Update(ukemployee);
            _dbContext.SaveChanges();
        }
    }

}
