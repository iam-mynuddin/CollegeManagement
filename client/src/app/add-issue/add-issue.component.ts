import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormControl, FormGroup, Validators } from '@angular/forms';
import { GetDataService } from '../_services/get-data.service';

@Component({
  selector: 'app-add-issue',
  templateUrl: './add-issue.component.html',
  styleUrls: ['./add-issue.component.css']
})
export class AddIssueComponent implements OnInit {
  source: any = {};
  faculties: any;
  allUsers: any;
  constructor(private http:HttpClient,private getData:GetDataService) {
  }

  ngOnInit(): void {
    this.getData.getAllFaculty().subscribe(result => { this.faculties = result; })
    this.getData.getAllUsers().subscribe(result => { this.allUsers = result; })    
  }
  raiseIssue() {
    //console.log(this.source);
    this.http.post('https://localhost:7141/api/issue/raiseissue', this.source).subscribe({
      next: response => {
        alert('Issue raised!');

      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
  }
  }

