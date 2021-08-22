using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RealTimeTrialONE.api.Dto;
using RealTimeTrialONE.api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace RealTimeTrialONE.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRoleService _emprservice;
        public EmployeeController(IEmployeeRoleService empsr)
        {
            _emprservice = empsr;
        }

        [HttpGet]
        public string GetById()
        {
            return "myRole";
        }

        [HttpPost("role")]
        [Consumes(MediaTypeNames.Application.Json)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> AddNewEmployeeRole([FromBody] EmployeeRoleDto newRole)
        {
            await _emprservice.AddNewEmployeeRole(newRole);
            return CreatedAtAction(nameof(AddNewEmployeeRole),new {role=newRole.Role },newRole);
        }
    }
}
