
import { Component, inject, OnChanges, OnInit, signal, Signal, SimpleChanges } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EmployeeInfo } from '../../Shared/services/employee-info';
import { Employee } from '../../Shared/model/EmployeeInfo.model';
import { Router } from '@angular/router';
import { Department, Designation, Gender, Section } from '../../Shared/model/Common.model';
import { CommonServices } from '../../Shared/services/common-services';
import { EventEmitter, Output } from '@angular/core';
import { Input } from '@angular/core';


@Component({
  selector: 'app-add-employee-info',
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './add-employee-info.html',
  styleUrl: './add-employee-info.css',
})
export class AddEmployeeInfo implements OnInit, OnChanges {
  ngOnInit(): void {
    this.loadDepartments();
    this.loadSections();
    this.loadDesignations();
    this.loadGenders();
  }
  private fb = inject(FormBuilder);
  private router = inject(Router);
  private departmentService = inject(CommonServices);
  private commonService = inject(CommonServices);
  departments= signal<Department[]>([]);
  section= signal<Section[]>([]);
  designations= signal<Designation[]>([]);
  gender= signal<Gender[]>([]);
  @Output() close = new EventEmitter<void>();
  @Input() employee: Employee | null = null;
  employeeService = inject(EmployeeInfo);
  employeeForm: FormGroup = this.fb.group({
  idClient: [0, Validators.required],
  id: [0], 

  employeeName: ['', Validators.required],
  employeeNameBangla: [''],
  employeeImage: [null],

  fatherName: [''],
  motherName: [''],

  idReportingManager: [null],
  idJobType: [null],
  idEmployeeType: [null],

  birthDate: [null],
  joiningDate: [null],

  idGender: [null],
  idReligion: [null],

  idDepartment: [null, Validators.required],
  idSection: [null, Validators.required],
  idDesignation: [null, Validators.required],

  hasOvertime: [false],
  hasAttendenceBonus: [false],

  idWeekOff: [null],

  address: [''],
  presentAddress: [''],
  nationalIdentificationNumber: [''],
  contactNo: [''],

  idMaritalStatus: [null]
});

private patchForm(emp: Employee) {
  this.employeeForm.patchValue({
    id: emp.id,
    idClient: emp.idClient,

    employeeName: emp.employeeName,
    employeeNameBangla: emp.employeeNameBangla,
    fatherName: emp.fatherName,
    motherName: emp.motherName,
    contactNo: emp.ContactNo,

    idDepartment: emp.idDepartment,
    idSection: emp.idSection,
    idDesignation: emp.idDesignation,

    idGender: emp.idGender,
    birthDate: emp.birthDate,
    joiningDate: emp.joiningDate,

    hasOvertime: emp.hasOvertime,
    hasAttendenceBonus: emp.hasAttendenceBonus,

    nationalIdentificationNumber: emp.nationalIdentificationNumber,
    address: emp.address,
    presentAddress: emp.presentAddress,
  });
}


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

  const payload = this.employeeForm.value;
  if (payload.id && payload.id > 0) {
    this.employeeService.updateEmployee(payload).subscribe({
      next: () => {
        this.close.emit();
        this.employeeForm.reset({ idClient: payload.idClient, id: 0 });
      },
      error: err => console.error(err)
    });
  }
  else {
    this.employeeService.addEmployee(payload).subscribe({
      next: () => {
        this.close.emit();
        this.employeeForm.reset({ idClient: payload.idClient, id: 0 });
      },
      error: err => console.error(err)
    });
  }
}

ngOnChanges(changes: SimpleChanges): void {
  console.log('ngOnChanges fired', changes);

  if (changes['employee'] && this.employee) {
    this.patchForm(this.employee);
  }
}

}
