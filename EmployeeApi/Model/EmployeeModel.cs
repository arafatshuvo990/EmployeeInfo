using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EmployeeApi.Model
{
    public class EmployeeModel
    {
        [Key]
        public int Id { get; set; }

   
        [Required]
        public int IdClient { get; set; }

        public string? EmployeeName { get; set; }
        public string? EmployeeNameBangla { get; set; }

        public byte[]? EmployeeImage { get; set; }

        public string? FatherName { get; set; }
        public string? MotherName { get; set; }

        public int? IdReportingManager { get; set; }
        public int? IdJobType { get; set; }
        public int? IdEmployeeType { get; set; }

        public DateTime? BirthDate { get; set; }
        public DateTime? JoiningDate { get; set; }

        public int? IdGender { get; set; }
        public int? IdReligion { get; set; }

    
        [Required]
        public int IdDepartment { get; set; }

        [Required]
        public int IdSection { get; set; }

        public int? IdDesignation { get; set; }

        public bool? HasOvertime { get; set; }
        public bool? HasAttendenceBonus { get; set; }

        public int? IdWeekOff { get; set; }

        public string? Address { get; set; }
        public string? PresentAddress { get; set; }

        public string? NationalIdentificationNumber { get; set; }
        public string? ContactNo { get; set; }

        public int? IdMaritalStatus { get; set; }

        public bool? IsActive { get; set; }
        public DateTime? SetDate { get; set; }

        public string? CreatedBy { get; set; }


        public Department? Department { get; set; }
        public Section? Section { get; set; }
        public Designation? Designation { get; set; }
    }
}
