using EmployeeApi.Models;

namespace EmployeeApi.Repositories.Interfaces
{
    public interface ICommonRepository
    {
        Task<List<Department>> GetDepartmentAllAsync();
        Task<List<Section>> GetSectionsAllAsync();
        Task<List<Designation>> GetAllDesignationAsync();
        Task<List<Gender>> GetAllGenderAsync();
        Task<List<EducationExamination>> GetEducationResltAsync();
        Task<List<EducationLevel>> GetEducationLevelsAsync();
        Task<List<EducationResult>> GetEducationResultAsync();
        Task<List<EducationExamination>> GetEducationExamName();
        Task <List<JobType>> GetJobTypesAsync();
        Task<List<Religion>> GetReligionsAsync();
    }
}
