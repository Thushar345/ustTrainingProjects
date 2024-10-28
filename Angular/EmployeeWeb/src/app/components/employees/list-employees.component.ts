import { Component } from '@angular/core';
import { Employee } from '../../models/employee';
import { DatePipe } from '@angular/common';

@Component({
  selector: 'app-list-employees',
  standalone: true,
  imports: [DatePipe],
  templateUrl: './list-employees.component.html',
  styleUrl: './list-employees.component.css'
})
export class ListEmployeesComponent {
  employees: Employee[]=[
    {
      id: 1,
      name: "John",
      gender: "Male",
      email: "john@gmail.com",
      phoneNumber: 9983783831,
      contactPreference: "string",
      dateOfBirth: new Date("12/02/2000"),
      department: "Manager",
      isActive: true,
      photoPath: "john.jpg"
    },
    {
      id: 2,
      name: "Lucy",
      gender: "Female",
      email: "lucy@gmail.com",
      phoneNumber: 9283759832,
      contactPreference: "string",
      dateOfBirth: new Date("05/04/2002"),
      department: "Buisiness Analyst",
      isActive: true,
      photoPath: "lucy.jpg"
    },
    {
      id: 3,
      name: "Daniel",
      gender: "Male",
      email: "daniel@gmail.com",
      phoneNumber: 9827478233,
      contactPreference: "string",
      dateOfBirth: new Date("08/12/2001"),
      department: "Strategy Analyst",
      isActive: true,
      photoPath: "daniel.jpg"
    }
  ]
}
