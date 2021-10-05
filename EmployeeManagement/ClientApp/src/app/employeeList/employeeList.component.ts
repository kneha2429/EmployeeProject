import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employeeList.component.html'
})
export class EmployeeListComponent {
  public employeeResult: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any>(baseUrl + 'api/Employee/GetEmployees').subscribe(result => {
      debugger;
      this.employeeResult = result;
    }, error => console.error(error));
  }
}
