using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EmployeeApi.Data;
using EmployeeApi.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EmployeeController(ApplicationDbContext context) : ControllerBase
    {
        [HttpGet("employee")]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await context.Employee.ToListAsync();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await context.Employee.FirstOrDefaultAsync(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee not found");

            return Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee([FromBody] EmployeeModel employee)
        {

            context.Employee.Add(employee);
            await context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmployeeById),
                new { id = employee.Id }, employee);
        }
    }
}