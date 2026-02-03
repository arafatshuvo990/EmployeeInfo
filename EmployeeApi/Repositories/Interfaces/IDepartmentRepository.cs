using EmployeeApi.Models;

namespace EmployeeApi.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        Task<List<Department>> GetAllAsync();
    }
}
