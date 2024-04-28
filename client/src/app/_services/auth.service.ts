import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, Subject, throwError } from 'rxjs';
import { catchError, map, retry } from 'rxjs/operators';
import { UserDto } from '../_models/models';

@Injectable({
  providedIn: 'root'
})

export class AuthService {
  url: string = "https://localhost:7141/api/login/login";
  public strCurrentUser: any;
  public strCurrentUserType: any;

  public currentUserSource = new BehaviorSubject<UserDto|null>(null);
  currentUser$ = this.currentUserSource.asObservable();

  constructor(private http: HttpClient, private router: Router) {
  }
  setCurrentUser(user: UserDto) {
    this.currentUserSource.next(user)
  }
  validateLogin(userDetails: any) {
    return this.http.post(this.url, userDetails).pipe(
      map((response: any) => {
        console.log(response);
        this.currentUserSource.next(response);
        this.strCurrentUser = response.userName;
        this.strCurrentUserType = response.userType;
        localStorage.setItem('user', JSON.stringify(response));
        return response;
      }
      ));
  }
  logout() {
    localStorage.removeItem('user');  
    this.currentUserSource.next(null);
  }
}
