using EmployeeApi.Mappers;
using EmployeeApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DepartmentController(IDepartmentRepository departmentRepository) : Controller
    {
        [HttpGet]
        public async Task<IActionResult> GetDepartment()
        {
            var department = await departmentRepository.GetAllAsync();
            var result = department
    .Select(DepartmentMapper.ToViewModel)
    .ToList();
            return Ok(result);
        }
        
    }
}
