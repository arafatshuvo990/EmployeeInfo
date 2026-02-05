using EmployeeApi.Models;
using EmployeeApi.ViewModels;

namespace EmployeeApi.Mappers
{
    public static class EmployeeEducationMapper
    {
        public static EmployeeEducationInfo ToEntity(
            CreateEmployeeEducationViewModel vm)
        {
            return new EmployeeEducationInfo
            {
                IdEmployee = vm.IdEmployee,

                IdEducationLevel = vm.IdEducationLevel,
                IdEducationExamination = vm.IdEducationExamination,
                IdEducationResult = vm.IdEducationResult,

                Cgpa = vm.Cgpa,
                ExamScale = vm.ExamScale,
                Marks = vm.Marks,

                Major = vm.Major,
                PassingYear = vm.PassingYear,
                InstituteName = vm.InstituteName,
                IsForeignInstitute = vm.IsForeignInstitute,

                Duration = vm.Duration,
                Achievement = vm.Achievement,
                SetDate = DateTime.Now
            };
        }
    }
}
