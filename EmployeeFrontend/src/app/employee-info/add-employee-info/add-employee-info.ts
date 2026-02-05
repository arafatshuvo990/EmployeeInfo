import { Component, inject, OnChanges, OnInit, signal, Signal, SimpleChanges } from '@angular/core';
import { FormBuilder, FormGroup, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { EmployeeInfo } from '../../Shared/services/employee-info';
import { Employee } from '../../Shared/model/EmployeeInfo.model';
import { Router } from '@angular/router';
import { Department, Designation, Gender, idEducationExamination, idEducationLevel, idEducationResult, jobType, Section } from '../../Shared/model/Common.model';
import { CommonServices } from '../../Shared/services/common-services';
import { EventEmitter, Output } from '@angular/core';
import { Input } from '@angular/core';
import { EducationInfoService } from '../../Shared/services/education-info';

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
    this.loadJobTypes();
    this.loadEducationLevels();
    this.loadEducationExaminations();
    this.loadEducationResults();
  }
  private fb = inject(FormBuilder);
  private router = inject(Router);
  private departmentService = inject(CommonServices);
  private commonService = inject(CommonServices);
  departments = signal<Department[]>([]);
  section = signal<Section[]>([]);
  designations = signal<Designation[]>([]);
  gender = signal<Gender[]>([]);
  jobTypes = signal<jobType[]>([]);
  educationExaminations = signal<idEducationExamination[]>([]);
  educationLevels = signal<idEducationLevel[]>([]);
  educationResults = signal<idEducationResult[]>([]);
  @Output() close = new EventEmitter<void>();
  @Input() employee: Employee | null = null;
  employeeService = inject(EmployeeInfo);
  educationService = inject(EducationInfoService);  
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

    idMaritalStatus: [null],
  });
  educationForm: FormGroup = this.fb.group({
    idEmployee: [0],

    idEducationLevel: [null, Validators.required],
    idEducationExamination: [null],
    idEducationResult: [null],

    cgpa: [null],
    examScale: [null],
    marks: [null],

    major: ['', Validators.required],
    passingYear: [null, Validators.required],
    instituteName: ['', Validators.required],
    isForeignInstitute: [false],

    duration: [null],
    achievement: [''],
  });

  private patchForm(emp: Employee) {
    console.log('PATCHING FORM WITH:', emp);

    this.employeeForm.patchValue({
      id: emp.id,
      idClient: emp.idClient,
      employeeName: emp.employeeName,
      employeeNameBangla: emp.employeeNameBangla,
      fatherName: emp.fatherName,
      motherName: emp.motherName,
      contactNo: emp.contactNo,
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
  loadEducationLevels() {
    this.commonService.getAllEducationLevels().subscribe({
      next: (res) => {
        this.educationLevels.set(res);
        console.log(this.educationLevels());
      }
      ,
      error: (err) => console.error('Failed to load education levels', err),
    });
  }
  loadGenders() {
    this.commonService.getAllGenders().subscribe({
      next: (res) => {
        this.gender.set(res);
        console.log(this.gender());
      },
      error: (err) => console.error('Failed to load genders', err),
    });
  }
  loadEducationExaminations() {
    this.commonService.getAllEducationExaminations().subscribe({
      next: (res) => {
        this.educationExaminations.set(res);
        console.log(this.educationExaminations());
      },
      error: (err) => console.error('Failed to load education examinations', err),
    });
  }
  loadEducationResults() {
    this.commonService.getAllEducationResults().subscribe({
      next: (res) => {
        this.educationResults.set(res);
        console.log(this.educationResults());
      }
      ,      error: (err) => console.error('Failed to load education results', err),
    });
  }
  loadJobTypes() {
    this.commonService.getAllJobTypes().subscribe({
      next: (res) => {
        this.jobTypes.set(res);
        console.log(this.jobTypes());
      },
      error: (err) => console.error('Failed to load job types', err),
    });
  }

  submitAll() {
 
  if (this.employeeForm.invalid) {
    this.employeeForm.markAllAsTouched();
    return;
  }

  if (this.educationForm.invalid) {
    this.educationForm.markAllAsTouched();
    return;
  }

  const employeePayload = this.employeeForm.value;

  this.employeeService.addEmployee(employeePayload).subscribe({
    next: (employeeRes) => {
      const employeeId = employeeRes.id;

      console.log('Employee saved, ID:', employeeId);

      const educationPayload = {
        ...this.educationForm.value,
        idEmployee: employeeId
      };

 
      this.educationService.addEducation(educationPayload).subscribe({
        next: () => {
          console.log('Education saved');


          this.employeeForm.reset({ idClient: employeePayload.idClient, id: 0 });
          this.educationForm.reset();

          this.close.emit();
        },
        error: err => {
          console.error('Education save failed', err);
        }
      });
    },
    error: err => {
      console.error('Employee save failed', err);
    }
  });
}

//   submit() {
//     if (this.employeeForm.invalid) {
//       this.employeeForm.markAllAsTouched();
//       return;
//     }

//     const payload = this.employeeForm.value;

//     if (!payload.id || payload.id === 0) {
//       this.employeeService.addEmployee(payload).subscribe({
//         next: (res) => {
//           const employeeId = res.id;

//           this.employeeForm.patchValue({ id: employeeId });

//           this.educationForm.patchValue({
//             idEmployee: employeeId,
//           });

//           console.log('Employee saved with ID:', employeeId);
//         },
//         error: (err) => console.error(err),
//       });
//     } else {
//       this.employeeService.updateEmployee(payload).subscribe({
//         next: () => {
//           console.log('Employee updated');
//         },
//         error: (err) => console.error(err),
//       });
//     }
//   }
//   submitEducation() {
//   if (this.educationForm.invalid) {
//     this.educationForm.markAllAsTouched();
//     return;
//   }

//   const payload = this.educationForm.value;

//   this.educationService.addEducation(payload).subscribe({
//     next: () => {
//       console.log('Education saved');
//       this.educationForm.reset({
//         idEmployee: this.employeeForm.value.id
//       });
//     },
//     error: err => console.error(err)
//   });
// }


  ngOnChanges(changes: SimpleChanges): void {
    console.log('ngOnChanges fired', changes);

    if (changes['employee'] && this.employee) {
      this.patchForm(this.employee);
    }
  }
}
