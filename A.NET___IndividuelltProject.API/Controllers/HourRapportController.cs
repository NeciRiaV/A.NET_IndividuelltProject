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
    public class HourRapportController : ControllerBase
    {
        private Iiproject<HourRapport> _appCon;
        public HourRapportController(Iiproject<HourRapport> appCon)
        {
            _appCon = appCon;
        }

        //GET ALL HOURRAPPORTS
        [HttpGet]
        public async Task<IActionResult> GetAllHourRapports()
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

        //ADD HOURRAPPORT
        [HttpPost]
        public async Task<ActionResult<HourRapport>> AddNewHourRapport(HourRapport newHr)
        {
            try
            {
                if (newHr == null)
                {
                    return BadRequest();
                }
                var createdHr = await _appCon.Add(newHr);
                return CreatedAtAction(nameof(GetSingHr), new { id = createdHr.HourRapportID }, createdHr);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error: Could not retrieve data from database...");
            }
        }

        //UPDATE/CHANGE HOURRAPPORT
        [HttpPut("{id}")]
        public async Task<ActionResult<HourRapport>> UpdateHourRapport(int id, HourRapport Hr)
        {
            try
            {
                if (id != Hr.HourRapportID)
                {
                    return BadRequest("HourRapport ID does not exist!");
                }
                var HrToUpdate = await _appCon.GetOne(id);
                if (HrToUpdate == null)
                {
                    return NotFound($"HourRapport with ID {id} not found");
                }
                return await _appCon.Update(Hr);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error: Could not retrieve data from database...");
            }
        }

        //DELETE HOURRAPPORT
        [HttpDelete("{id}")]
        public async Task<ActionResult<HourRapport>> DeleteHourRapport(int id)
        {
            try
            {
                var HrToDelete = await _appCon.GetOne(id);
                if (HrToDelete == null)
                {
                    return NotFound($"HourRapport with ID {id} not found!");
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
        public async Task<ActionResult<HourRapport>> GetSingHr(int id)
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
                    "Error: couldn't retrieve data from database...");
            }
        }

        [HttpGet]
        [Route("getdate/{id}/{week}")]
        public async Task<ActionResult<HourRapport>> GetDate([FromRoute]int id,[FromRoute] int week)
        {
            try
            {
                var result = await _appCon.GetDate(id, week);
                return Ok(result);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error: couldn't retrieve data from database...");
            }
        }
    }
}
