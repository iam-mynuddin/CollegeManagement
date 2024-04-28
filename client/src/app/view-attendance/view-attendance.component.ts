import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-view-attendance',
  templateUrl: './view-attendance.component.html',
  styleUrls: ['./view-attendance.component.css']
})
export class ViewAttendanceComponent implements OnInit {

  result: any;
  pageUser = 'all students';
  constructor(private http:HttpClient) { }

  ngOnInit(): void {
   
    this.http.get('https://localhost:7141/api/attendance/getattendancelist').subscribe({
      next:response=>{
        this.result = response;
    },
      error :error => {
        alert('Error! Check console!');
        console.log(error);
      }
    });
  }

}

