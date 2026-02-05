import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { EmployeeEducation } from '../model/EmployeeEducation.model';

@Injectable({ providedIn: 'root' })
export class EducationInfoService {
  private apiUrl = 'http://localhost:5106/api/EducationInfo';

  constructor(private http: HttpClient) {}

  addEducation(education: EmployeeEducation) {
  return this.http.post(this.apiUrl, education);
}
}
