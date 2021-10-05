using EM.Entities.Models;
using EmployeeManagement.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly EmployeeService _employeeService;
        public WeatherForecastController(EmployeeService employeeService)
        {
            _employeeService = employeeService;

        }

    private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
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
