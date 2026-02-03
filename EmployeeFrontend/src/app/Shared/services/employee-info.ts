import { Injectable } from '@angular/core';
import { Employee } from '../model/EmployeeInfo.model';
import { environment } from '../../environments/environment';
import { HttpClient } from '@angular/common/http';
@Injectable({ providedIn: 'root' })
export class EmployeeInfo {
  private apiUrl = 'http://localhost:5106/api/Employee';

  constructor(private http: HttpClient) {}

  getAllEmployees() {
    return this.http.get<Employee[]>(this.apiUrl);
  }
}

