import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GetDataService } from '../_services/get-data.service';

@Component({
  selector: 'app-add-attendance',
  templateUrl: './add-attendance.component.html',
  styleUrls: ['./add-attendance.component.css']
})
export class AddAttendanceComponent implements OnInit {
  source: any = {};
  faculties: any;
  students: any;
  allUsers: any;
  allCourses: any;
  allSubjects: any;
  constructor(private http: HttpClient, private getData: GetDataService) {
  }

  ngOnInit(): void {
    this.getData.getAllFaculty().subscribe(result => { this.faculties = result; });
    this.getData.getAllStudents().subscribe(result => { this.students = result; });
    this.getData.getAllUsers().subscribe(result => { this.allUsers = result; });
    this.getData.getAllCourses().subscribe(result => { this.allCourses = result; });
    this.getData.getAllSubjects().subscribe(result => { this.allSubjects = result; });
  }
  submitToServer() {
    this.http.post('https://localhost:7141/api/attendance/addattendance', this.source).subscribe({
      next: response => {
        alert('Attendance updated!');
      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
  }
}
