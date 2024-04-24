import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './_services/auth.service';

interface WeatherForecast {
  date: string;
  temperatureC: number;
  temperatureF: number;
  summary: string;
}

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent implements OnInit {

  constructor(private http: HttpClient,private router:Router,public auth:AuthService) {}

  ngOnInit() {
    this.setCurrentUser();
  }
  goToHome() {
    let userType: any = ''
    this.auth.currentUser$.subscribe({
      next: res => {
        userType = res.userType;
      },
      error: err => { userType = 'none'; }
    }
    );
    if (userType == 'Student') {
      this.router.navigate(['/student']);
    }
    else if (userType == 'Admin') {
      this.router.navigate(['/admin']);
    }
    else if (userType == 'Faculty') {
      this.router.navigate(['/faculty'])
    }
    else if (userType == 'Parent') {
      this.router.navigate(['/parent'])
    }
    else
      this.router.navigateByUrl('/home')
  } 
  setCurrentUser() {
    //const user: User = JSON.parse(localStorage.getItem('user')!);
    const strUser = localStorage.getItem('user');
    if (!strUser) return;
    const user: any = JSON.parse(strUser);
    this.auth.SetCurrentUser(user);
  }
  Logout() {
    this.auth.Logout();
    this.router.navigateByUrl('/')
  }

}
