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
                Id = vm.Id,
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
                Id = e.Id,
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
        public static void UpdateEntity(Employee emp, UpdateEmployeeViewModel vm)
        {
            emp.EmployeeName = vm.EmployeeName ?? emp.EmployeeName;
            emp.EmployeeNameBangla = vm.EmployeeNameBangla ?? emp.EmployeeNameBangla;
            emp.EmployeeImage = vm.EmployeeImage ?? emp.EmployeeImage;

            emp.FatherName = vm.FatherName ?? emp.FatherName;
            emp.MotherName = vm.MotherName ?? emp.MotherName;

            emp.IdReportingManager = vm.IdReportingManager ?? emp.IdReportingManager;
            emp.IdJobType = vm.IdJobType ?? emp.IdJobType;
            emp.IdEmployeeType = vm.IdEmployeeType ?? emp.IdEmployeeType;

            emp.BirthDate = vm.BirthDate ?? emp.BirthDate;
            emp.JoiningDate = vm.JoiningDate ?? emp.JoiningDate;

            emp.IdGender = vm.IdGender ?? emp.IdGender;
            emp.IdReligion = vm.IdReligion ?? emp.IdReligion;

            emp.IdDepartment = vm.IdDepartment;
            emp.IdSection = vm.IdSection;
            emp.IdDesignation = vm.IdDesignation ?? emp.IdDesignation;

            emp.HasOvertime = vm.HasOvertime ?? emp.HasOvertime;
            emp.HasAttendenceBonus = vm.HasAttendenceBonus ?? emp.HasAttendenceBonus;

            emp.IdWeekOff = vm.IdWeekOff ?? emp.IdWeekOff;
            emp.Address = vm.Address ?? emp.Address;
            emp.PresentAddress = vm.PresentAddress ?? emp.PresentAddress;
            emp.NationalIdentificationNumber =
                vm.NationalIdentificationNumber ?? emp.NationalIdentificationNumber;
            emp.ContactNo = vm.ContactNo ?? emp.ContactNo;

            emp.IdMaritalStatus = vm.IdMaritalStatus ?? emp.IdMaritalStatus;
        }


    }
}
