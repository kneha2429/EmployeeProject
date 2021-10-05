import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../Services/employee.service';

@Component({
  selector: 'employee-detail',
  templateUrl: './employeeDetail.component.html',
  styleUrls: ['./employeeDetail.component.css'],
})
export class EmployeeDetailComponent implements OnInit {
  public currentCount = 0;

  message: string;

  parentMessage = "Value from Parent";

  public incrementCounter() {
    this.currentCount++;
  }

  receiveMessage($event) {
    this.message = $event;
  }

  constructor(private employeeService: EmployeeService) { }

  ngOnInit() {
    this.employeeService.currentMessage.subscribe(message => this.message = message)
  }

  newMessage() {
    this.employeeService.changeMessage("Hello from sibling");
  }
}
