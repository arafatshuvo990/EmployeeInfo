using EmployeeApi.Data;
using EmployeeApi.Mappers;
using EmployeeApi.Models;
using EmployeeApi.Repositories.Interfaces;
using EmployeeApi.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    public class EmployeeController(HrmDbContext context, IEmployeeRepository employeeRepo) : ControllerBase
    {
        [HttpGet()]
        public async Task<IActionResult> GetEmployees()
        {
            var employees = await employeeRepo.GetAllAsync();
            var result = employees
            .Select(EmployeeMapper.ToViewModel)
            .ToList();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployeeById(int id)
        {
            var employee = await context.Employees.FirstOrDefaultAsync(e => e.Id == id);

            if (employee == null)
                return NotFound("Employee not found");

            return Ok(employee);
        }
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeViewModel vm)
        {
            var employee = EmployeeMapper.ToEntity(vm);
            employeeRepo.AddAsync(employee);
            await context.SaveChangesAsync();

            return Ok(EmployeeMapper.ToViewModel(employee));
        }


    }
}