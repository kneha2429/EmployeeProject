import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-fetch-data',
  templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
  public statesResult: any;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<any>('https://cdn-api.co-vin.in/api/v2/admin/location/states').subscribe(result => {
      this.statesResult = result;
    }, error => console.error(error));
  }
}
