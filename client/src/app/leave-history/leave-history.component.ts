import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-leave-history',
  templateUrl: './leave-history.component.html',
  styleUrls: ['./leave-history.component.css']
})
export class LeaveHistoryComponent implements OnInit {

  pageUser = 'all users';
  result: any;

  constructor(private http: HttpClient) { }


  ngOnInit(): void {

    this.http.get('https://localhost:7141/api/leavedetails/getleavehistory').subscribe({
      next: response=> {
        this.result = response;
      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
  }

}
