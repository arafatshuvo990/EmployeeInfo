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
    }
}
