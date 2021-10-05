import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-ukemployee-list',
  templateUrl: './ukEmployees.component.html'
})
export class UKEmployeesComponent {
  public employeeResult: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any>(baseUrl + 'api/UKEmployee/GetUKEmployees').subscribe(result => {
      debugger;
      this.employeeResult = result;
    }, error => console.error(error));
  }
}
