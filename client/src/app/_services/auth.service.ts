import { Injectable } from '@angular/core';
import { Router } from '@angular/router';
import { HttpClient } from '@angular/common/http';
import { BehaviorSubject, Observable, Subject, throwError } from 'rxjs';
import { catchError, map, retry } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})

export class AuthService {
  url: string = "https://localhost:7141/api/login/login";

  private isLoggedIn = new BehaviorSubject<boolean>(false);
  private CallMethodSource = new Subject<any>();
  CallMethodSource$ = this.CallMethodSource.asObservable();

  private currentUserSource = new BehaviorSubject<any>({});
  currentUser$ = this.currentUserSource.asObservable();

  SetCurrentUser(user: any) {
    this.currentUserSource.next(user)
  }

  SetAuthenticated() {
    this.CallMethodSource.next(true);
  }
  OnLoggedIn = this.isLoggedIn.asObservable(); 

  constructor(private http: HttpClient, private router: Router) {
  }

  isAuthenticated(status: boolean) {
    this.isLoggedIn.next(status);
  }
  Validate(userDetails: any) {
    return this.http.post(this.url, userDetails).pipe(
      map((response: any) => {
        this.currentUserSource.next(response);
        localStorage.setItem('user', JSON.stringify(response));
        //console.log(response);
        return response;
      }
      ));
  }
  Logout() {
    this.isLoggedIn.next(false);
    localStorage.removeItem('user');  
    this.currentUserSource.next({});
  }
}
