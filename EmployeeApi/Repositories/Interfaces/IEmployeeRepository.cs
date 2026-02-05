using EmployeeApi.Models;
using EmployeeApi.ViewModels;

namespace EmployeeApi.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int idClient, int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(int id, UpdateEmployeeViewModel updateEmployeeViewModel);
        Task DeleteAsync(int id);
        Task SaveAsync();
    }
}
