export interface Employee {
  id: number;

  idClient: number;

  employeeName?: string;
  employeeNameBangla?: string;

  employeeImage?: Uint8Array;

  fatherName?: string;
  motherName?: string;

  idReportingManager?: number;
  idJobType?: number;
  idEmployeeType?: number;

  birthDate?: Date;
  joiningDate?: Date;

  idGender?: number;
  idReligion?: number;

  idDepartment: number;
  idSection: number;

  idDesignation?: number;

  hasOvertime?: boolean;
  hasAttendenceBonus?: boolean;

  idWeekOff?: number;

  address?: string;
  presentAddress?: string;

  nationalIdentificationNumber?: string;
  contactNo?: string;

  idMaritalStatus?: number;

  isActive?: boolean;
  setDate?: Date;

  createdBy?: string;

//   department?: Department;
//   section?: Section;
//   designation?: Designation;
}
