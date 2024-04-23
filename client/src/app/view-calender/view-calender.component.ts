import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Calendar } from '../_models/calender';

@Component({
  selector: 'app-view-calender',
  templateUrl: './view-calender.component.html',
  styleUrls: ['./view-calender.component.css']
})
export class ViewCalenderComponent implements OnInit {


  calenders: Calendar[] = [];

  constructor(private http:HttpClient) { }

  ngOnInit(): void {
   
    this.http.get('https://localhost:7141/api/calendar/getcalendarlist').subscribe(
      response=>{
        this.calenders=response as Calendar[];

      },
      error=>{
        alert('error fetching data');

      });
  }

}
