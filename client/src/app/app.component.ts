import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { AuthService } from './_services/auth.service';
import { map } from 'rxjs';
import { UserDto } from './_models/models';

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
    //console.log(this.auth.currentUser$);
  }
  goToHome() {
    let userType = this.auth.strCurrentUserType;
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
    const strUser = localStorage.getItem('user');
    if (!strUser) return;
    const user: UserDto = JSON.parse(strUser);
    //console.log(user);
    this.auth.strCurrentUserType = user.userType;
    this.auth.strCurrentUser = user.userName;
    this.auth.setCurrentUser(user);
  }
  logout() {
    this.auth.logout();
    this.router.navigateByUrl('/')
  }

}
