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

  submitted: boolean = false;
  loginForm: any;
  flag: any;

  selectedType: string = '';
  userID!: number;
  user!: User;
  constructor(private authService: AuthService, private router: Router, public formBuilder: FormBuilder) {
  }
  ngOnInit(): void {
    this.loginForm = this.formBuilder.group({
      UserName: ['', [Validators.compose([Validators.required])]],
      Password: ['', [Validators.required, Validators.minLength(3)]],
    });
  }
  ngOnDestroy() { }
  get f() {
    return this.loginForm.controls;
  }


  Login() {
    this.submitted = true;
    const userDetails = {
      UserName: this.loginForm.get("UserName")?.value,
      Password: this.loginForm.get('Password')?.value
    }
    this.authService.Validate(userDetails).subscribe({
      next: (res: any) => {
        if (res) {
          this.authService.isAuthenticated(true);
          this.flag = res;
          this.user = res;
          this.userID = res.UserId;
          console.log(this.authService.currentUser$);

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
        this.authService.isAuthenticated(false);
        console.log(error);
        alert(error.error);
      }
    });
    
  }
  
}

