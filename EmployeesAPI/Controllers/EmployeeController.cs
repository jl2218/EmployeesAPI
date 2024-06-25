using EmployeesAPI.Models;
using EmployeesAPI.Services.EmployeeServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmployeesAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeInterface _employeeInterface;
        public EmployeeController(IEmployeeInterface employeeInterface)
        {
            _employeeInterface = employeeInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<EmployeeModel>>>> GetEmployees()
        {
            return Ok(await _employeeInterface.GetEmployees());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> GetEmployeeById(int id)
        {
            return Ok(await _employeeInterface.GetEmployeeById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> CreateEmployee(EmployeeModel newEmployee)
        {
            return Ok(await _employeeInterface.CreateEmployee(newEmployee));
        }

        [HttpPut("update")]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> UpdateEmployee(EmployeeModel updatedEmployee)
        {
            return Ok(await _employeeInterface.UpdateEmployee(updatedEmployee));
        }

        [HttpPut("activateEmployee")]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> ActivateEmployee(int id)
        {
            return Ok(await _employeeInterface.ActivateEmployee(id));
        }

        [HttpPut("inactivateEmployee")]
        public async Task<ActionResult<ServiceResponse<EmployeeModel>>> InactivateEmployee(int id)
        {
            return Ok(await _employeeInterface.InactivateEmployee(id));
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<string>>> DeleteEmployee(int id)
        {
            return Ok(await _employeeInterface.DeleteEmployee(id));
        }
    }
}
