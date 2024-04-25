import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Assignment } from '../_models/assignment';

@Component({
  selector: 'app-view-assignment',
  templateUrl: './view-assignment.component.html',
  styleUrls: ['./view-assignment.component.css']
})
export class ViewAssignmentComponent implements OnInit {
  
  result: any;
  pageUser = 'all students';


  constructor(private http:HttpClient) { }

  ngOnInit(): void {

    this.http.get('https://localhost:7141/api/assignment/getassignments').subscribe({
      next: response => {
        this.result = response;
      },
      error: error => {
        alert('Error! Check console!');
        console.log(error);
      }
    });
  }
}
