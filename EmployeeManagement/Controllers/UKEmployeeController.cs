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
    public class UKEmployeeController : ControllerBase
    {
        private readonly AddressService _addressService;

        public UKEmployeeController(AddressService addressService)
        {
            _addressService = addressService;

        }

        [HttpPost]
        [Route("InsertUKEmployee")]
        public async Task<IActionResult> InsertEmployee([FromBody] Ukemployee ukemployee)
        {
            await _addressService.InsertUKEmployee(ukemployee);
            return Ok();
        }

        [HttpDelete]
        [Route("UKEmployeeDelete")]
        public IActionResult Delete(int id)
        {
            _addressService.DeleteUKEmployee(id);
            return Ok();

        }

        [HttpGet]
        [Route("GetUKEmployees")]
        public List<Ukemployee> GetUKEmployees()
        {
            List<Ukemployee> employees = new List<Ukemployee>();
            employees = _addressService.GetUKEmployees();
            return employees;
        }

        [HttpPut]
        [Route("UpdateUKEmployee")]
        public IActionResult UpdateEmployee(Ukemployee emp)
        {
            _addressService.UpdateUKEmployee(emp);
            return Ok();
        }
    }
}
