import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Department, Designation, Gender, idEducationExamination, idEducationLevel, idEducationResult, jobType, Section } from '../model/Common.model';
@Injectable({
  providedIn: 'root',
})
export class CommonServices {
  private apiUrl = 'http://localhost:5106/api/Common';
     constructor(private http: HttpClient) {}

    getAllDepartments() {
      return this.http.get<Department[]>(this.apiUrl + '/departments');
    }
    
    getAllSections() {
      return this.http.get<Section[]>(this.apiUrl + '/sections');
    }
    getAllDesignations() {
      return this.http.get<Designation[]>(this.apiUrl + '/designation');
    }
    getAllGenders() {
      return this.http.get<Gender[]>(this.apiUrl + '/gender');
    }
    getAllJobTypes() {
      return this.http.get<jobType[]>(this.apiUrl + '/jobtypes');
    }
    getAllEducationLevels() {
      return this.http.get<idEducationLevel[]>(this.apiUrl + '/educationlevel');
    }
    getAllEducationExaminations() {
      return this.http.get<idEducationExamination[]>(this.apiUrl + '/education-examination');
    }
    getAllEducationResults() {
      return this.http.get<idEducationResult[]>(this.apiUrl + '/educationresultname');
    }
}
