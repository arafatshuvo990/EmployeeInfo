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
  addEmployee(employee: Employee) {
    return this.http.post<Employee>(this.apiUrl, employee);
  }

  updateEmployee(employee: Employee) {
  return this.http.put(
    `${this.apiUrl}/${employee.idClient}/${employee.id}`,
    employee
  );
}
deleteEmployee(id: number) {
  return this.http.delete(`${this.apiUrl}/${id}`);
}
}

