import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Issue } from '../_models/issue';

@Component({
  selector: 'app-view-issue',
  templateUrl: './view-issue.component.html',
  styleUrls: ['./view-issue.component.css']
})
export class ViewIssueComponent implements OnInit {

  //issues: Issue[] = [];
  issues: any;

  constructor(private http:HttpClient) { }

  ngOnInit(): void {
   
    this.http.get('https://localhost:7141/api/issue/getissuereports').subscribe(
      response=>{
        this.issues = response as Issue[];
        console.log(this.issues.toString());
      },
      error=>{
        alert('Error fetching data');
      });
  }

}
