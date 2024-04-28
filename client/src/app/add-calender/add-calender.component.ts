import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GetDataService } from '../_services/get-data.service';

@Component({
  selector: 'app-add-calender',
  templateUrl: './add-calender.component.html',
  styleUrls: ['./add-calender.component.css']
})
export class AddCalenderComponent implements OnInit {

  source: any = {};
  
  constructor(private http: HttpClient, private getData: GetDataService) {
  }

  ngOnInit(): void {
  }
  submitToServer() {
    this.http.post('https://localhost:7141/api/calendar/addcalendar', this.source).subscribe({
      next: response => {
        alert('Event added!');
      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
  }
}
