import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, map, retry } from 'rxjs/operators';
import { AuthService } from './auth.service';
import { User, UserDto } from '../_models/models';


@Injectable({
  providedIn: 'root'
})
export class GetDataService {
  baseUrl: string = 'https://localhost:7141/api/data/'
  currentUser: any;
  result: any = {};
  constructor(public http: HttpClient, private auth: AuthService) {
  }

  getAllFaculty() {
    return this.http.get(this.baseUrl + 'getallfaculty');
  }
  getAllStudents() {
    return this.http.get(this.baseUrl + 'getallstudents');
  }
  getAllFaculties() {
    return this.http.get(this.baseUrl + 'getallfaculties');
  }
  getAllParents() {
    return this.http.get(this.baseUrl + 'getallparents');
  }
  getUserById(userId:number) {
    return this.http.get(this.baseUrl + 'getuserbyid/'+userId);
  }
  getAllUsers() {
    return this.http.get(this.baseUrl + 'getallusers');
  }
  getAllCourses() {
    return this.http.get(this.baseUrl + 'getallcourses');
  }
  getAllSubjects() {
    return this.http.get(this.baseUrl + 'getallsubjects');
  }
  
}
