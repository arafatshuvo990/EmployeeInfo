using EmployeeApi.Models;
using EmployeeApi.ViewModels;

namespace EmployeeApi.Mappers
{
    public class CommonMapper
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
        public static SectionViewModel ToViewModel(Section section)
        {
            return new SectionViewModel
            {
                IdClient = section.IdClient,
                Id = section.Id,
                SectionName = section.SectionName,
                SectionNameBangla = section.SectionNameBangla,
                ShortName = section.ShortName,
            };
        }
        public static DesignationViewModel ToViewModel(Designation designation)
        {
            return new DesignationViewModel
            {
                IdClient = designation.IdClient,
                Id = designation.Id,
                DesignationName = designation.DesignationName,
                DesignationNameBangla = designation.DesignationNameBangla,
            };
        }
        public static GenderViewModel ToViewModel(Gender gender)
        {
            return new GenderViewModel
            {
                IdClient = gender.IdClient,
                Id = gender.Id,
                GenderName = gender.GenderName,
            };
        }
        public static EducationExaminationViewModel ToEducationExaminationViewModel(
    EducationExamination educationExamination)
        {
            return new EducationExaminationViewModel
            {
                IdClient = educationExamination.IdClient,
                Id = educationExamination.Id,
                ExamName = educationExamination.ExamName,
                IdEducationLevel = educationExamination.IdEducationLevel
            };
        }


        public static EducationLevelViewModel ToViewModel(EducationLevel educationLevel) {

            return new EducationLevelViewModel
            {
                IdClient = educationLevel.IdClient,
                EducationLevelName = educationLevel.EducationLevelName,
                Id = educationLevel.Id,
                Description = educationLevel.Description,
            };
        
        }
        public static EducationResultViewModel ToViewModel(EducationResult educationResult) {
            return new EducationResultViewModel
            {
                IdClient = educationResult.IdClient,
                Id = educationResult.Id,
                Description = educationResult.Description,
                ResultName = educationResult.ResultName,
            };
        
        }
        public static JobTypeViewModel ToViewModel(JobType jobType)
        {
            return new JobTypeViewModel
            {
                IdClient = jobType.IdClient,
                Id = jobType.Id,
                JobTypeName = jobType.JobTypeName,
                JobTypeBanglaName = jobType.JobTypeBanglaName,
            };
        }

        public static EmployeeTypeViewModel ToViewModel(EmployeeType employeeType)
        {
            return new EmployeeTypeViewModel
            {
                IdClient = employeeType.IdClient,
                Id = employeeType.Id,
                TypeName = employeeType.TypeName,
            };
        }
        public static ReligionViewaModel ToViewModel(Religion religion)
        {
            return new ReligionViewaModel
            {
                IdClient = religion.IdClient,
                Id = religion.Id,
                ReligionName = religion.ReligionName,
                SetDate = religion.SetDate,

            };
        }
     //   public static EducationExamNameViewModel ToEducationExamNameViewModel(
     //EducationExamination educationExamination)
     //   {
     //       return new EducationExamNameViewModel
     //       {
     //           IdClient = educationExamination.IdClient,
     //           Id = educationExamination.Id,
     //           ExamName = educationExamination.ExamName
     //       };
     //   }


    }
}
