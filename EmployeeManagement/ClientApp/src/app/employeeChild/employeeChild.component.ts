import { Component, Input, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'employeeChild',
  templateUrl: './employeeChild.component.html',
  inputs: ['']
})
export class EmployeeChildComponent {

  message: string = "Message from Child";

  @Input() childMessage: string;

  @Output() messageEvent = new EventEmitter<string>();

  public incrementCounter() {

    this.messageEvent.emit(this.message);
  }

  constructor(){}

}
