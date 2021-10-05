import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../Services/employee.service';

@Component({
  selector: 'app-counter-component',
  templateUrl: './counter.component.html'
})
export class CounterComponent implements OnInit {
  public currentCount = 0;
  message: string;

  constructor(private employeeService: EmployeeService) { }

  public incrementCounter() {
    this.currentCount++;
  }

  ngOnInit() {
    this.employeeService.currentMessage.subscribe(result => this.message = result);
  }
}
