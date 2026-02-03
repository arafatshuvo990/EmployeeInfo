import { Component, Inject } from '@angular/core';
import { CommonModule } from '@angular/common';
import { OnInit } from '@angular/core';
import { EmployeeInfo } from '../../Shared/services/employee-info';
import { Employee } from '../../Shared/model/EmployeeInfo.model';
@Component({
  selector: 'app-employee-info',
  imports: [CommonModule],
  templateUrl: './employee-info.html',
  styleUrl: './employee-info.css',
})
export class EmployeeInfoComponent implements OnInit {
  employees: Employee[] = [];

  employeeService = Inject(EmployeeInfo)
  ngOnInit(): void {
    this.getEmployeeInfo();
  }

  getEmployeeInfo() {
    this.employeeService.getAllEmployees().subscribe({
      next: (res: Employee[]) => {
        this.employees = res;
        console.log('Employees fetched successfully:', this.employees);
      },
      error: (err: any) => console.error('Error block triggered:', err),
    });
  }
}
