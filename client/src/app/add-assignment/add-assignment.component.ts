import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GetDataService } from '../_services/get-data.service';
import { Assignment } from '../_models/models';

@Component({
  selector: 'app-add-assignment',
  templateUrl: './add-assignment.component.html',
  styleUrls: ['./add-assignment.component.css']
})
export class AddAssignmentComponent implements OnInit {
  source: any = {};
  allFaculties: any;
  allStudents: any;
  allUsers: any;
  allCourses: any;
  allSubjects: any;
  constructor(private http: HttpClient, private getData: GetDataService) {
  }

  ngOnInit(): void {
    this.getData.getAllFaculty().subscribe(result => { this.allFaculties = result; });
    this.getData.getAllStudents().subscribe(result => { this.allStudents = result; });
    this.getData.getAllUsers().subscribe(result => { this.allUsers = result; });
    this.getData.getAllCourses().subscribe(result => { this.allCourses = result; });
    this.getData.getAllSubjects().subscribe(result => { this.allSubjects = result; });
  }
  submitToServer() {
    this.http.post('https://localhost:7141/api/assignment/allotassignment',this.source).subscribe({
      next: response => {
        alert('Assignmnet alloted!');
      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
  }
}
