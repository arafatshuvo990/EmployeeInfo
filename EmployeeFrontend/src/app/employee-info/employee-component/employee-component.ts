import { Component, inject, signal } from '@angular/core';
import { CommonModule } from '@angular/common';
import { EmployeeInfo } from '../../Shared/services/employee-info';
import { Employee } from '../../Shared/model/EmployeeInfo.model';
import { AddEmployeeInfo } from '../add-employee-info/add-employee-info';

@Component({
  selector: 'app-employee-component',
  standalone: true,
  imports: [CommonModule, AddEmployeeInfo],
  templateUrl: './employee-component.html',
})
export class EmployeeComponent {
  employees = signal<Employee[]>([]);
  showAddForm = signal(false);
  selectedEmployee = signal<Employee | null>(null);

  private employeeService = inject(EmployeeInfo);

  ngOnInit() {
    this.getEmployeeInfo();
  }

  getEmployeeInfo() {
    this.employeeService.getAllEmployees().subscribe({
      next: (res: Employee[]) => {
        this.employees.set(res);
        console.log('Employees loaded:', res);
      },
      error: (err) => console.error('Failed to load employees:', err),
    });
  }

  closeForm() {
    this.showAddForm.set(false);
    this.getEmployeeInfo();
  }
  deleteEmployee(id: number) {
    this.employeeService.deleteEmployee(id).subscribe({
      next: () => {
        console.log(`Employee with ID ${id} deleted successfully.`);
        this.getEmployeeInfo();
      },
      error: (err) => console.error(`Failed to delete employee with ID ${id}:`, err),
    });
  }
  editEmployee(emp: Employee) {
    this.selectedEmployee.set(null);

    setTimeout(() => {
      this.selectedEmployee.set(emp);
      this.showAddForm.set(true);
    });
  }
}
