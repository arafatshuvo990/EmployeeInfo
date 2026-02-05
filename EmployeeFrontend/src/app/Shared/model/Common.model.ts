export interface Department {
  id: number;
  idClient: number;
  departName: string;
  departNameBangla?: string;
  isActive?: boolean;
}
export interface Section {
  id: number;
  idClient: number;
  sectionName: string;
}

export interface Designation {
  id: number;
  idClient: number;
  designationName: string;
  designationNameBangla?: string;
}
export interface Gender{
  id: number;
  idClient: number;
  genderName: string;
}
export interface jobType{
  id: number;
  idClient: number;
  jobTypeName: string;
}
export interface idEducationLevel{
  id: number;
  idClient: number;
  educationLevelName: string;
}
export interface idEducationExamination{
  id: number;
  idClient: number;
  examName: string;
}
export interface idEducationResult{
  id: number;
  idClient: number;
  resultName: string;
}