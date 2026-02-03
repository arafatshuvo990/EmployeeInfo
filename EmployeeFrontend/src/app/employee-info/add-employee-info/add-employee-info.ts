
import { Component, inject } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EmployeeInfo } from '../../Shared/services/employee-info';
import { Employee } from '../../Shared/model/EmployeeInfo.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-add-employee-info',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './add-employee-info.html',
  styleUrl: './add-employee-info.css',
})
export class AddEmployeeInfo {
  private fb = inject(FormBuilder);
  private router = inject(Router);

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
