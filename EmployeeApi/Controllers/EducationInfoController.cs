using EmployeeApi.Mappers;
using EmployeeApi.Repositories.Interfaces;
using EmployeeApi.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EducationInfoController(IEmployeeEducation employeeEducation) : ControllerBase
    {


        [HttpPost]
        public async Task<IActionResult> CreateEducation(
            CreateEmployeeEducationViewModel vm)
        {
            var education = EmployeeEducationMapper.ToEntity(vm);

            await employeeEducation.AddAsync(education);
            await employeeEducation.SaveAsync();

            return Ok();
        }
    }
}
