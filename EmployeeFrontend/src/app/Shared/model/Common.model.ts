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