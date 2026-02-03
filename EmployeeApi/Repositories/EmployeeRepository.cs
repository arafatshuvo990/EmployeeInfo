using EmployeeApi.Data;
using EmployeeApi.Models;
using EmployeeApi.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EmployeeApi.Repositories
{
    public class EmployeeRepository(HrmDbContext context) : IEmployeeRepository
    {

        public async Task<List<Employee>> GetAllAsync()
        {
            return await context.Employees.Include(e => e.Department).Include(e=>e.Designation).Include(e=>e.Gender).Include(e=>e.JobType).ToListAsync();
        }

        public async Task<Employee?> GetByIdAsync(int idClient, int id)
        {

            return await context.Employees
                .FirstOrDefaultAsync(e => e.IdClient == idClient && e.Id == id);
        }

        public async Task AddAsync(Employee employee)
        {
            await context.Employees.AddAsync(employee);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
