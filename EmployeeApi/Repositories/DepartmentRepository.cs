using EmployeeApi.Data;
using EmployeeApi.Models;
using EmployeeApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Repositories
{
    public class DepartmentRepository(HrmDbContext context) : IDepartmentRepository
    {
        public async Task<List<Department>> GetAllAsync()
        {
            return await context.Departments.ToListAsync();
        }
    }
}
