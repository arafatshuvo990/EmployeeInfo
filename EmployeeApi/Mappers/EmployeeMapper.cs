using EmployeeApi.Models;
using EmployeeApi.ViewModels;

namespace EmployeeApi.Mappers
{
    public static class EmployeeMapper
    {
       
        public static Employee ToEntity(CreateEmployeeViewModel vm)
        {
            return new Employee
            {
                EmployeeName = vm.EmployeeName,
                EmployeeNameBangla = vm.EmployeeNameBangla,
                //EmployeeImage = vm.EmployeeImage,
                FatherName = vm.FatherName,
                MotherName = vm.MotherName,
                //IdReportingManager = vm.IdReportingManager,
                //IdJobType = vm.IdJobType,
                //IdEmployeeType = vm.IdEmployeeType,
                //BirthDate = vm.BirthDate,
                //JoiningDate = vm.JoiningDate,
                //IdGender = vm.IdGender,
                //IdReligion = vm.IdReligion,
                IdDepartment = vm.IdDepartment,
                IdSection = vm.IdSection,
                IdDesignation = vm.IdDesignation,
                //HasOvertime = vm.HasOvertime,
                //HasAttendenceBonus = vm.HasAttendenceBonus,
                //IdWeekOff = vm.IdWeekOff,
                //Address = vm.Address,
                //PresentAddress = vm.PresentAddress,
                //NationalIdentificationNumber = vm.NationalIdentificationNumber,
                //ContactNo = vm.ContactNo,
                //IdMaritalStatus = vm.IdMaritalStatus

            };
        }

        public static EmployeeViewModel ToViewModel(Employee e)
        {
            return new EmployeeViewModel
            {
                IdClient = e.IdClient,
                EmployeeName = e.EmployeeName,
                EmployeeNameBangla = e.EmployeeNameBangla,
                EmployeeImage = e.EmployeeImage,
                FatherName = e.FatherName,
                MotherName = e.MotherName,
                IdReportingManager = e.IdReportingManager,
                IdJobType = e.IdJobType,
                IdEmployeeType = e.IdEmployeeType,
                BirthDate = e.BirthDate,
                JoiningDate = e.JoiningDate,
                IdGender = e.IdGender,
                IdReligion = e.IdReligion,
                IdDepartment = e.IdDepartment,
                IdSection = e.IdSection,
                IdDesignation = e.IdDesignation,
                HasOvertime = e.HasOvertime,
                HasAttendenceBonus = e.HasAttendenceBonus,
                IdWeekOff = e.IdWeekOff,
                Address = e.Address,
                PresentAddress = e.PresentAddress,
                NationalIdentificationNumber = e.NationalIdentificationNumber,
                ContactNo = e.ContactNo,
                IdMaritalStatus = e.IdMaritalStatus
            };
        }

    }
}
