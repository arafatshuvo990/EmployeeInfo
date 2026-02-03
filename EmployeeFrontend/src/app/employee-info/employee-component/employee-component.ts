import { Component, inject, signal} from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeInfo } from '../../Shared/services/employee-info';
import { Employee } from '../../Shared/model/EmployeeInfo.model';
import { Router } from '@angular/router';
@Component({
  selector: 'app-employee-component',
  imports: [CommonModule],
  templateUrl: './employee-component.html',
  styleUrl: './employee-component.css',
})
export class EmployeeComponent {
  employees = signal<Employee[]>([]);

  employeeService = inject(EmployeeInfo);
  private router = inject(Router);
  ngOnInit(): void {
    this.getEmployeeInfo();
  }
  getEmployeeInfo() {
    this.employeeService.getAllEmployees().subscribe({
      next: (res: Employee[]) => {
        this.employees.set(res); 
        console.log('Employees fetched successfully:', this.employees);
      },
      error: (err: any) => console.error('Error block triggered:', err),
    });
  }
  goToAddEmployee() {
    this.router.navigate(['/employees/add']);
  }
}
