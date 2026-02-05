using EmployeeApi.Models;

namespace EmployeeApi.Repositories.Interfaces
{
    public interface ICommonRepository
    {
        Task<List<Department>> GetDepartmentAllAsync();
        Task<List<Section>> GetSectionsAllAsync();
        Task<List<Designation>> GetAllDesignationAsync();
        Task<List<Gender>> GetAllGenderAsync();
        Task<List<EducationExamination>> GetEducationExaminationAsync();
        Task<List<EducationLevel>> GetEducationLevelsAsync();
        Task<List<EducationResult>> GetEducationResultAsync();
    }
}
