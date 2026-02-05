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
                IdClient = vm.IdClient,

                EmployeeName = vm.EmployeeName,
                EmployeeNameBangla = vm.EmployeeNameBangla,
                EmployeeImage = vm.EmployeeImage,

                FatherName = vm.FatherName,
                MotherName = vm.MotherName,

                IdReportingManager = vm.IdReportingManager,
                IdJobType = vm.IdJobType,
                IdEmployeeType = vm.IdEmployeeType,

                BirthDate = vm.BirthDate,
                JoiningDate = vm.JoiningDate,

                IdGender = vm.IdGender,
                IdReligion = vm.IdReligion,
                IdDepartment = vm.IdDepartment,
                IdSection = vm.IdSection,
                IdDesignation = vm.IdDesignation,
                IdMaritalStatus = vm.IdMaritalStatus,
                IdWeekOff = vm.IdWeekOff,

                HasOvertime = vm.HasOvertime ?? false,
                HasAttendenceBonus = vm.HasAttendenceBonus ?? false,

                ContactNo = vm.ContactNo,
                Address = vm.Address,
                PresentAddress = vm.PresentAddress,
                NationalIdentificationNumber = vm.NationalIdentificationNumber,

                
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
                DepartmentName = e.Department?.DepartName,
                Designation = e.Designation?.DesignationName,
                Gender = e.Gender?.GenderName,
                JobType = e.JobType?.JobTypeName,
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
        public static void UpdateEntity(Employee emp, CreateEmployeeViewModel vm)
        {
            emp.EmployeeName = vm.EmployeeName;
            emp.EmployeeNameBangla = vm.EmployeeNameBangla;
            emp.EmployeeImage = vm.EmployeeImage;

            emp.FatherName = vm.FatherName;
            emp.MotherName = vm.MotherName;

            emp.IdReportingManager = vm.IdReportingManager;
            emp.IdJobType = vm.IdJobType;
            emp.IdEmployeeType = vm.IdEmployeeType;

            emp.BirthDate = vm.BirthDate;
            emp.JoiningDate = vm.JoiningDate;

            emp.IdGender = vm.IdGender;
            emp.IdReligion = vm.IdReligion;

            emp.IdDepartment = vm.IdDepartment;
            emp.IdSection = vm.IdSection;
            emp.IdDesignation = vm.IdDesignation;

            emp.HasOvertime = vm.HasOvertime ?? false;
            emp.HasAttendenceBonus = vm.HasAttendenceBonus ?? false;

            emp.IdWeekOff = vm.IdWeekOff;
            emp.Address = vm.Address;
            emp.PresentAddress = vm.PresentAddress;
            emp.NationalIdentificationNumber = vm.NationalIdentificationNumber;
            emp.ContactNo = vm.ContactNo;

            emp.IdMaritalStatus = vm.IdMaritalStatus;

        }

    }
}
