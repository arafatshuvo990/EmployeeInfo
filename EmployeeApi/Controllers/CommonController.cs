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
            .Select(CommonMapper.ToViewModel)
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

       

        [HttpGet("educationlevel")]

        public async Task<IActionResult> GetEducationLevelsAsync()
        {
            var educationlevel = await commonRepository.GetEducationLevelsAsync();
            var result = educationlevel
                .Select( CommonMapper.ToViewModel) .ToList();
            return Ok(result);
        }
        [HttpGet("educationresultname")]

        public async Task<IActionResult> GetEducationResultAsync()
        {
            var educationresult = await commonRepository.GetEducationResultAsync();
            var result = educationresult
                .Select( CommonMapper.ToViewModel) .ToList();
            return Ok(result);
        }

        [HttpGet("jobtypes")]
        public async Task<IActionResult> GetJobTypesAsync()
        {
            var jobtypes = await commonRepository.GetJobTypesAsync();
            var result = jobtypes
                .Select(CommonMapper.ToViewModel).ToList();
            return Ok(result);
        }

        [HttpGet("religios")]
        public async Task <IActionResult> GetReligionsAsync()
        {
            var religions = await commonRepository.GetReligionsAsync();
            var result = religions
                .Select( CommonMapper.ToViewModel) .ToList();
            return Ok(result);
        }
        [HttpGet("education-examination")]
        public async Task<IActionResult> GetEducationExamName()
        {
            var educationExam = await commonRepository.GetEducationExamName();

            var result = educationExam
                .Select(CommonMapper.ToEducationExaminationViewModel)
                .ToList();

            return Ok(result);
        }


    }
}
