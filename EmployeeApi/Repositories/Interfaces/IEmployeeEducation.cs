using EmployeeApi.Models;

namespace EmployeeApi.Repositories.Interfaces
{
    public interface IEmployeeEducation
    {
        Task AddAsync(EmployeeEducationInfo employeeEducation);
        Task SaveAsync();
    }
}
