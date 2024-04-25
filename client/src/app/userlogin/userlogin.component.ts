import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { AuthService } from '../_services/auth.service';
import { User } from '../_models/user';

@Component({
  selector: 'app-userlogin',
  templateUrl: './userlogin.component.html',
  styleUrls: ['./userlogin.component.css']
})
export class UserloginComponent implements OnInit {
  source: any = {};
  constructor(private authService: AuthService, private router: Router, public formBuilder: FormBuilder) {
  }
  ngOnInit(): void {
    
  }
  ngOnDestroy() { }
  
  loginUser() {
    this.authService.validateLogin(this.source).subscribe({
      next: (res: any) => {
        if (res) {
          //console.log(this.authService.currentUser$);
          if (res.userType == 'Student') {
            this.router.navigate(['/student']);
          }
          else if (res.userType == 'Admin') {
            this.router.navigate(['/admin']);
          }
          else if (res.userType == 'Faculty') {
            this.router.navigate(['/faculty'])
          }
          else if (res.userType == 'Parent') {
            this.router.navigate(['/parent'])
          }
          else
            alert('Please check you login details');
        }
      },
      error: (error: any) => {
        console.log(error);
        alert(error.error);
      }
    });
    
  }
  
}

