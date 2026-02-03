import { Component, inject} from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeInfo } from '../../Shared/services/employee-info';
import { Employee } from '../../Shared/model/EmployeeInfo.model';

@Component({
  selector: 'app-employee-component',
  imports: [CommonModule],
  templateUrl: './employee-component.html',
  styleUrl: './employee-component.css',
})
export class EmployeeComponent {
  employees: Employee[] = [];

  employeeService = inject(EmployeeInfo);
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
