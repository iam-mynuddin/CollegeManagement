import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-view-calender',
  templateUrl: './view-calender.component.html',
  styleUrls: ['./view-calender.component.css']
})
export class ViewCalenderComponent implements OnInit {

  result: any;
  pageUser = 'all students';

  constructor(private http:HttpClient) { }

  ngOnInit(): void {   
    this.http.get('https://localhost:7141/api/calendar/getcalendarlist').subscribe({
      next: response => {
        this.result = response;
      },
      error: error => {
        alert('Error! check console!')
        console.log(error);
      }
    });
  }

}
