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

    }
}
