
import { Component, inject, OnInit, signal, Signal } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EmployeeInfo } from '../../Shared/services/employee-info';
import { Employee } from '../../Shared/model/EmployeeInfo.model';
import { Router } from '@angular/router';
import { DepartmentService } from '../../Shared/services/departmentService';
import { Department } from '../../Shared/model/Department.model';
import { Designation, Gender, Section } from '../../Shared/model/Common.model';
import { CommonServices } from '../../Shared/services/common-services';

@Component({
  selector: 'app-add-employee-info',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './add-employee-info.html',
  styleUrl: './add-employee-info.css',
})
export class AddEmployeeInfo implements OnInit {
  ngOnInit(): void {
    this.loadDepartments();
    this.loadSections();
    this.loadDesignations();
    this.loadGenders();
  }
  private fb = inject(FormBuilder);
  private router = inject(Router);
  private departmentService = inject(DepartmentService);
  private commonService = inject(CommonServices);
  departments= signal<Department[]>([]);
  section= signal<Section[]>([]);
  designations= signal<Designation[]>([]);
  gender= signal<Gender[]>([]);
  employeeService = inject(EmployeeInfo);
  employeeForm: FormGroup = this.fb.group({
    idClient: [0, Validators.required],

    employeeName: ['', Validators.required],
    employeeNameBangla: [''],

    fatherName: [''],
    motherName: [''],
    ContactNo: [''],
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
  loadSections() {
    this.commonService.getAllSections().subscribe({
      next: (res) => {
        this.section.set(res);
        console.log('Sections loaded', this.section());
      },
      error: (err) => console.error('Failed to load sections', err),
    });
  }
  loadDesignations() {
    this.commonService.getAllDesignations().subscribe({
      next: (res) => {
        this.designations.set(res);
      },
      error: (err) => console.error('Failed to load designations', err),
    });
  }

  loadGenders() {
    this.commonService.getAllGenders().subscribe({
      next: (res) => {
        this.gender.set(res);
        console.log(this.gender())
      },
      error: (err) => console.error('Failed to load genders', err),
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
