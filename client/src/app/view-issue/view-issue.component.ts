import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Issue } from '../_models/issue';

@Component({
  selector: 'app-view-issue',
  templateUrl: './view-issue.component.html',
  styleUrls: ['./view-issue.component.css']
})
export class ViewIssueComponent implements OnInit {

  pageUser = 'all users';
  result :any;

  constructor(private http:HttpClient) { }

  ngOnInit(): void {
   
    this.http.get('https://localhost:7141/api/issue/getissuereports').subscribe({
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
