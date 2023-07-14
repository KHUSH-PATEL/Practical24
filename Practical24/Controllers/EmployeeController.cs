using DataAccessLayer.Dto;
using DataAccessLayer.Services.EmployeeService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Practical24.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeService _employeeService;
        public EmployeeController(IEmployeeService empService)
        {
            _employeeService = empService;
        }

        [HttpGet]
        public IActionResult GetEmployee()
        {
            var data = _employeeService.GetEmployee();
            return Ok(data);
        }
        [HttpGet("{id}")]
        public IActionResult GetEmployee(int id)
        {
            var data = _employeeService.GetEmployee(id);
            if (data == null)
                return NotFound($"No data with id:{id}");
            return Ok(data);
        }
        [HttpPost]
        public IActionResult AddEmployee([FromBody] EmployeeDto emp)
        {
            _employeeService.AddEmployee(emp);
            return Ok();
        }
        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] EmployeeDto emp)
        {
            var data = _employeeService.EditEmployee(id, emp);
            if (data != null)
                return Ok(data);
            else
                return NotFound($"No data with id:{id}");
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            var result = _employeeService.DeleteEmployee(id);
            if (result != null)
                return Ok(result);
            else
                return NotFound($"No data with id:{id}");
        }
    }
}
