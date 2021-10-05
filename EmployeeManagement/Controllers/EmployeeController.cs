using EM.Entities.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController(EmployeeService employeeService)
        {
            _employeeService = employeeService;

        }

        [HttpPost]
        [Route("Insert")]
        public async Task<IActionResult> InsertEmployee([FromBody] Employee employee)
        {
                await _employeeService.InsertEmployee(employee);
                return Ok();
        }

        [HttpDelete]
        [Route("EmployeeDelete")]
        public IActionResult Delete(int id)
        {
            _employeeService.DeleteEmployee(id);
            return Ok();

        }

        [HttpGet]
        [Route("GetEmployees")]
        public List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            employees = _employeeService.GetEmployees();
            return employees;
        }

        [HttpPut]
        [Route("UpdateEmployees")]
        public IActionResult UpdateEmployee(Employee emp)
        {
            _employeeService.UpdateEmployee(emp);
            return Ok();
        }
    }
}
