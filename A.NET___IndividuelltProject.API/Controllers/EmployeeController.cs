using A.NET___IndividuelltProject.API.Services;
using A.NET___IndividuelltProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace A.NET___IndividuelltProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private Iiproject<Employee> _appCon;
        public EmployeeController(Iiproject<Employee> appCon)
        {
            _appCon = appCon;
        }
        //GET ALL EMPLOYEES 
        [HttpGet]
        public async Task<IActionResult> GetAllEmployees()
        {
            try
            {
                return Ok(await _appCon.GetAll());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error: Could not retrieve data from database...");
            }
        }

        //GET ALL HOUR RAPPORTS FOR SPECIFIK EMPLOYEE
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetSingelEmployee(int id)
        {
            var result = await _appCon.GetSingelOne(id);
            if (result.Any())
            {
                return Ok(result);
            }
            return NotFound();
        }

        //GET WEEKLY HOUR AMOUNT FOR SPECIFIK EMPLOYEE


        ////ADD EMPLOYEE
        [HttpPost]
        public async Task<ActionResult<Employee>> AddNewEmp(Employee newEmployee)
        {
            try
            {
                if (newEmployee == null)
                {
                    return BadRequest();
                }
                var createdNewEmp = await _appCon.Add(newEmployee);
                return CreatedAtAction(nameof(GetSingEmp), new { id = createdNewEmp.EmployeeID }, createdNewEmp);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //UPDATE/CHANGE EMPLOYEE
        [HttpPut("{id}")]
        public async Task<ActionResult<Employee>> UpdateEmployee(int id, Employee emp)
        {
            try
            {
                if (id != emp.EmployeeID)
                {
                    return BadRequest("Employee ID doesn't exist...");
                }
                var EmpToUpdate = await _appCon.GetOne(id);
                if (EmpToUpdate == null)
                {
                    return NotFound($"Employee with ID {id} not found...");
                }
                return await _appCon.Update(emp);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    ("Error: could not update Employee in database"));
            }
        }

        //DELETE EMPLOYEE
        [HttpDelete("{id}")]
        public async Task<ActionResult<Employee>> DeleteEmployee(int id)
        {
            try
            {
                var result = await _appCon.GetOne(id);
                if (result == null)
                {
                    return NotFound($"Employee with ID {id} could not be found");
                }
                return await _appCon.Delete(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    ("Error: could not update Employee in database"));
            }
        }

        //Get singel, only used for Add
        [HttpGet("{getone}")]
        public async Task<ActionResult<Employee>> GetSingEmp(int id)
        {
            try
            {
                var result = await _appCon.GetOne(id);
                if (result == null)
                {
                    return NotFound();
                }
                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, 
                    "Error: couldn't retrieve singel employee from database...");
            }
        }
    }
}
