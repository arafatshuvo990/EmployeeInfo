import { Routes } from '@angular/router';
import { AddEmployeeInfo } from './employee-info/add-employee-info/add-employee-info';
import { EmployeeComponent } from './employee-info/employee-component/employee-component';

export const routes: Routes = [
  { path: '', redirectTo: 'employees', pathMatch: 'full' },
  { path: 'employees', component: EmployeeComponent },
  { path: 'employees/add', component: AddEmployeeInfo },
];

