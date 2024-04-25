import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Leave } from '../_models/leave';

@Component({
  selector: 'app-view-leave',
  templateUrl: './view-leave.component.html',
  styleUrls: ['./view-leave.component.css']
})
export class ViewLeaveComponent implements OnInit {

  pageUser = 'all users';
  result: any;

  constructor(private http:HttpClient) { }
  

  ngOnInit(): void {
   
    this.http.get('https://localhost:7141/api/leavedetails/getleavedetails').subscribe({
      next: response => {
        this.result = response;
      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
    }


}
