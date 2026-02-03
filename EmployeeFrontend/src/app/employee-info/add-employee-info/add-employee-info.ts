
import { Component, inject, OnInit, signal, Signal } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EmployeeInfo } from '../../Shared/services/employee-info';
import { Employee } from '../../Shared/model/EmployeeInfo.model';
import { Router } from '@angular/router';
import { DepartmentService } from '../../Shared/services/departmentService';
import { Department } from '../../Shared/model/Department.model';

@Component({
  selector: 'app-add-employee-info',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './add-employee-info.html',
  styleUrl: './add-employee-info.css',
})
export class AddEmployeeInfo implements OnInit {
  ngOnInit(): void {
    this.loadDepartments();
  }
  private fb = inject(FormBuilder);
  private router = inject(Router);
  private departmentService = inject(DepartmentService);
  departments= signal<Department[]>([]);
  employeeService = inject(EmployeeInfo);
  employeeForm: FormGroup = this.fb.group({
    idClient: [0, Validators.required],

    employeeName: ['', Validators.required],
    employeeNameBangla: [''],

    fatherName: [''],
    motherName: [''],

    idDepartment: [null, Validators.required],
    idSection: [null, Validators.required],
    idDesignation: [null, Validators.required],
  });
  loadDepartments() {
    this.departmentService.getAllDepartments().subscribe({
      next: (res) => {
        this.departments.set(res);
        console.log('Departments loaded', this.departments());
      },
      error: (err) => console.error('Failed to load departments', err),
    });
  }

  submit() {
    if (this.employeeForm.invalid) {
      this.employeeForm.markAllAsTouched();
      return;
    }

    const employee: Employee = this.employeeForm.value;

    this.employeeService.addEmployee(employee).subscribe({
      next: (res) => {
        console.log('Employee added successfully', res);
        this.router.navigate(['/employees']);
        this.employeeForm.reset({ idClient: 0 });
      },
      error: (err) => {
        console.error('Failed to add employee', err);
      }
    });
  }
}
