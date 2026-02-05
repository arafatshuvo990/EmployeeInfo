using EmployeeApi.Models;

namespace EmployeeApi.Repositories.Interfaces
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee?> GetByIdAsync(int idClient, int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int idClient, int id);
        Task SaveAsync();
    }
}
