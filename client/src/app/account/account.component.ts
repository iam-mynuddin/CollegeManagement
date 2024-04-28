import { Component } from '@angular/core';
import { UserDto } from '../_models/models';
import { GetDataService } from '../_services/get-data.service';
import { HttpClient } from '@angular/common/http';
import { AuthService } from '../_services/auth.service';

@Component({
  selector: 'app-account',
  templateUrl: './account.component.html',
  styleUrls: ['./account.component.css']
})
export class AccountComponent {
  currentUser: any;
  source: any = {};
  faculties: any;
  students: any;
  allUsers: any;
  allCourses: any;
  allSubjects: any;
  constructor(private http: HttpClient, private getData: GetDataService,private auth:AuthService) {
  }

  ngOnInit(): void {
    this.auth.currentUser$.subscribe(result => this.currentUser = result);
    this.getData.getUserById(this.currentUser.userId).subscribe(result => { this.source = result });
    this.getData.getAllStudents().subscribe(result => { this.students = result; });
    this.getData.getAllUsers().subscribe(result => { this.allUsers = result; });
    this.getData.getAllCourses().subscribe(result => { this.allCourses = result; });
    this.getData.getAllSubjects().subscribe(result => { this.allSubjects = result; });
  }
  submitToServer() {
    this.http.post('https://localhost:7141/api/users/updateuser', this.source).subscribe({
      next: response => {
        alert('Account details updated!');
      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
  }
}
