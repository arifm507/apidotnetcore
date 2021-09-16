using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementCRUD.EmployeeData;
using StudentManagementCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementCRUD.Controllers
{
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private IEmployeeData _employeeData;

        public EmployeeController(IEmployeeData employeeData)
        {
            this._employeeData = employeeData;
        }

        [HttpGet]
        [Route("api/[controller]")]
        public IActionResult GetEmployees() {
            return Ok(_employeeData.GetEmployeeList());
        }

        [HttpGet]
        [Route("api/[controller]/{id}")]
        public IActionResult GetEmployees(Guid id)
        {

            var employee = _employeeData.GetEmployee(id);
            if (employee != null)
            {
                return Ok(employee);
            }
            return NotFound($"Employee with id: {id} was not found");
        }

        [HttpPost]
        [Route("api/[controller]")]
        public IActionResult AddEmployee(Employee employee)
        {
            _employeeData.AddEmployee(employee);
            return Created(HttpContext.Request.Scheme + "://" + HttpContext.Request.Host + HttpContext.Request.Path + employee.Id, employee);
        }

        [HttpDelete]
        [Route("api/[controller]/{id}")]
        public IActionResult AddEmployee(Guid id)
        {
            var employee = _employeeData.GetEmployee(id);
            if (employee != null) {
                _employeeData.DeleteEmployee(employee);
                return Ok("Employee Deleted Successfully");
            }
            return NotFound($"Employee with id: {id} was not found");
        }
    }
}
