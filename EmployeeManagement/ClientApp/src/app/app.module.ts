import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { RouterModule } from '@angular/router';

import { AppComponent } from './app.component';
import { NavMenuComponent } from './nav-menu/nav-menu.component';
import { HomeComponent } from './home/home.component';
import { CounterComponent } from './counter/counter.component';
import { FetchDataComponent } from './fetch-data/fetch-data.component';
import { EmployeeDetailComponent } from './employeeDetail/employeeDetail.component';
import { EmployeeChildComponent } from './employeeChild/employeeChild.component';
import { EmployeeService } from '../Services/employee.service';
import { EmployeeListComponent } from './employeeList/employeeList.component';
import { UKEmployeesComponent } from './ukEmployees/ukEmployees.component';

@NgModule({
  declarations: [
    AppComponent,
    NavMenuComponent,
    HomeComponent,
    CounterComponent,
    FetchDataComponent,
    EmployeeDetailComponent,
    EmployeeChildComponent,
    EmployeeListComponent,
    UKEmployeesComponent
  ],
  imports: [
    BrowserModule.withServerTransition({ appId: 'ng-cli-universal' }),
    HttpClientModule,
    FormsModule,
    RouterModule.forRoot([
      { path: '', component: HomeComponent, pathMatch: 'full' },
      { path: 'counter', component: CounterComponent },
      { path: 'fetch-data', component: FetchDataComponent },
      { path: 'employee', component: EmployeeDetailComponent },
      { path: 'employeeList', component: EmployeeListComponent },
      { path: 'ukemployees', component: UKEmployeesComponent }
    ])
  ],
  providers: [EmployeeService],
  bootstrap: [AppComponent]
})
export class AppModule { }
