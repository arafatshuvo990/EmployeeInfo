using EmployeeApi.Mappers;
using EmployeeApi.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CommonController(ICommonRepository commonRepository) : Controller
    {
        [HttpGet("departments")]
        public async Task<IActionResult> GetDepartment()
        {
            var department = await commonRepository.GetDepartmentAllAsync();
            var result = department
            .Select(DepartmentMapper.ToViewModel)
            .ToList();
            return Ok(result);
        }

        [HttpGet("sections")]
        public async Task<IActionResult> GetSection()
        {
            var section = await commonRepository.GetSectionsAllAsync();
            var result = section
                .Select(CommonMapper.ToViewModel) .ToList();
            return Ok(result);
        }
        [HttpGet("designation")]

        public async Task<IActionResult> GetAllDesignationAsync()
        {
            var designation = await commonRepository.GetAllDesignationAsync();
            var result = designation
                .Select(CommonMapper.ToViewModel) .ToList();
            return Ok(result);
        }

        [HttpGet("gender")]

        public async Task<IActionResult> GetAllGenderAsync()
        {
            var gender = await commonRepository.GetAllGenderAsync();
            var result = gender
                .Select(CommonMapper.ToViewModel) .ToList();
            return Ok(result);
        }

    }
}
