using EmployeeApi.Data;
using EmployeeApi.Models;
using EmployeeApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Repositories
{
    public class CommonRepository(HrmDbContext context) : ICommonRepository
    {
        public async Task<List<Department>> GetDepartmentAllAsync()
        {
            return await context.Departments.ToListAsync();
        }
        public async Task<List<Section>> GetSectionsAllAsync()
        {
            return await context.Sections.ToListAsync();
        }
        

        public async Task<List<Designation>> GetAllDesignationAsync()
        {
            return await context.Designations.ToListAsync();
        }

        public async Task<List<Gender>> GetAllGenderAsync()
        {
            return await context.Genders.ToListAsync();
        }

        public async Task<List<EducationExamination>> GetEducationResltAsync()
        {
            return await context.EducationExaminations.ToListAsync();
        }

        public async Task<List<EducationLevel>> GetEducationLevelsAsync()
        {
            return await context.EducationLevels.ToListAsync();
        }

        public async Task<List<EducationResult>> GetEducationResultAsync()
        {
            return await context.EducationResults.ToListAsync();
        }

        public async Task<List<JobType>> GetJobTypesAsync()
        {
            return await context.JobTypes.ToListAsync();
        }

        public async Task<List<Religion>> GetReligionsAsync()
        {
            return await context.Religions.ToListAsync();
        }

        public async Task<List<EducationExamination>> GetEducationExamName()
        {
            return await context.EducationExaminations.ToListAsync();
        }
    }
}
