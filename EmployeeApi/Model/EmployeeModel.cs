using System;

namespace EmployeeApi.Model
{
   
    public class EmployeeModel
{
    public int Id { get; set; }
    public int IdClient { get; set; }
    public string? EmployeeName { get; set; }
    public string? EmployeeNameBangla { get; set; }
    
    // Corrected to byte array for VARBINARY
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
    
    // These are NOT NULL in DB, so standard int is fine
    public int IdDepartment { get; set; }
    public int IdSection { get; set; }
    
    public int? IdDesignation { get; set; }

    // If DB allows NULL for bit, use bool?
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
    
    // Corrected to string for NVARCHAR
    public string? CreatedBy { get; set; } 
}
}
