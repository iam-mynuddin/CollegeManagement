import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';

@Component({
  selector: 'app-super-secret',
  templateUrl: './super-secret.component.html',
  styleUrls: ['./super-secret.component.css']
})
export class SuperSecretComponent {
  users: any;


  constructor(private http:HttpClient) { }

  ngOnInit():any{
  this.getAllUsers();
}
getAllUsers(){
  this.http.get('https://localhost:7141/api/login/supersecret').subscribe({
    next: response => {
      this.users = response;
      console.log(this.users);
    },
    error: error => {
      console.log(error);
    }
  });
}
}
