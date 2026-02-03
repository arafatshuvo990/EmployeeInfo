import { Injectable } from '@angular/core';

import { HttpClient } from '@angular/common/http';
import { Department } from '../model/Department.model';
@Injectable({
  providedIn: 'root',
})
export class DepartmentService {
   private apiUrl = 'http://localhost:5106/api/Department';
     constructor(private http: HttpClient) {}

    getAllDepartments() {
      return this.http.get<Department[]>(this.apiUrl);
    }
}
