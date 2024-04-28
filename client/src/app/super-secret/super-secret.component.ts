import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { GetDataService } from '../_services/get-data.service';

@Component({
  selector: 'app-super-secret',
  templateUrl: './super-secret.component.html',
  styleUrls: ['./super-secret.component.css']
})
export class SuperSecretComponent {
  Users: any;
  Students: any;
  Parents: any;
  Subjects: any;
  Courses: any;
  Faculties: any;


  constructor(private http:HttpClient,private data:GetDataService) { }

  ngOnInit(): any{
    this.getAllUsers();
    this.data.getAllStudents().subscribe(res => this.Students = res);
    this.data.getAllParents().subscribe(res => this.Parents = res);
    this.data.getAllFaculties().subscribe(res => this.Faculties = res);
    this.data.getAllSubjects().subscribe(res => this.Subjects = res);
    this.data.getAllCourses().subscribe(res => this.Courses = res);
}
getAllUsers(){
  this.http.get('https://localhost:7141/api/login/supersecret').subscribe({
    next: response => {
      this.Users = response;
      console.log(this.Users);
    },
    error: error => {
      console.log(error);
    }
  });
}
}
