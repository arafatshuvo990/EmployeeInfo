using EmployeeApi.Data;
using EmployeeApi.Models;
using EmployeeApi.Repositories.Interfaces;

namespace EmployeeApi.Repositories
{
    public class EducationInfoRepository(HrmDbContext context) : IEmployeeEducation
    {
        public async Task AddAsync(EmployeeEducationInfo educationInfo)
        {
            await context.EmployeeEducationInfos.AddAsync(educationInfo);
        }

        public async Task SaveAsync()
        {
            await context.SaveChangesAsync();
        }
    }
}
