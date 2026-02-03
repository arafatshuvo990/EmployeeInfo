import { Component, signal } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import { EmployeeInfoComponent } from "./Components/employee-info/employee-info";
import { EmployeeComponent } from "./employee-info/employee-component/employee-component";

@Component({
  selector: 'app-root',
  imports: [ EmployeeComponent],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App {
  protected readonly title = signal('EmployeeFrontend');
}
