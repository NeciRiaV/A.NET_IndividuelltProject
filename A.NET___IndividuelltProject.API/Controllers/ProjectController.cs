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
    public class ProjectController : ControllerBase
    {
        private Iiproject<Project> _appCon;
        public ProjectController(Iiproject<Project> appCon)
        {
            _appCon = appCon;
        }

        //GET ALL PROJECTS
        [HttpGet]
        public async Task<IActionResult> GetAllProjects()
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

        //GET ALL EMPLOYEES FOR SINGLE PROJECT
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEmployeesPerProject(int id)
        {
            return Ok(await _appCon.GetSingel(id));
        }


        //ADD NEW PROJECT
        [HttpPost]
        public async Task<ActionResult<Project>> AddNewProject(Project newProject)
        {
            try
            {
                if (newProject == null)
                {
                    return BadRequest();
                }
                var createdProject = await _appCon.Add(newProject);
                return CreatedAtAction(nameof(GetSingPro),new {id = createdProject.ProjectID }, createdProject);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error: Could not retrieve data from database...");
            }
        }

        //UPDATE/CHANGE PROJECT
        [HttpPut("{id}")]
        public async Task<ActionResult<Project>> UpdateProject(int id, Project pro)
        {
            try
            {
                if (id != pro.ProjectID)
                {
                    return BadRequest("Project ID does not exist!");
                }
                var ProjectToUpdate = await _appCon.GetOne(id);
                if (ProjectToUpdate == null)
                {
                    return NotFound($"Project with ID {id} not found");
                }
                return await _appCon.Update(pro);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error: Could not retrieve data from database...");
            }
        }

        //DELETE PROJECT
        [HttpDelete("{id}")]
        public async Task<ActionResult<Project>> DeleteProject(int id)
        {
            try
            {
                var projectToDelete = await _appCon.GetOne(id);
                if (projectToDelete == null)
                {
                    return NotFound($"Project with ID {id} not found!");
                }
                return await _appCon.Delete(id);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error: Could not retrieve data from database...");
            }
        }




        //Get singel, only used for Add
        [HttpGet("{getone}")]
        public async Task<ActionResult<Project>> GetSingPro(int id)
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
