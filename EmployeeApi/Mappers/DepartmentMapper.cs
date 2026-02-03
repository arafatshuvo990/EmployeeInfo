using EmployeeApi.Models;
using EmployeeApi.ViewModels;

namespace EmployeeApi.Mappers
{
    public class DepartmentMapper
    {
        public static DepartmentViewModels ToViewModel(Department d)
        {
            return new DepartmentViewModels
            {
                IdClient = d.IdClient,
                Id = d.Id,
                DepartName = d.DepartName,
                DepartNameBangla = d.DepartNameBangla,
            };
        }
    }
}
