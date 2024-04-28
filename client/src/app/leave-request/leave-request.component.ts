import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormGroup, FormBuilder, Validators } from '@angular/forms';
import { LeaveDetail } from '../_models/models';
import { GetDataService } from '../_services/get-data.service';

@Component({
  selector: 'app-leave-request',
  templateUrl: './leave-request.component.html',
  styleUrls: ['./leave-request.component.css']
})
export class LeaveRequestComponent implements OnInit {
  source: any = {};
  allUsers: any;
  constructor(private http: HttpClient, private getData: GetDataService) {
  }

  ngOnInit(): void {
    this.getData.getAllUsers().subscribe(result => { this.allUsers = result; })
  }
  submitToServer() {
    this.http.post('https://localhost:7141/api/leavedetails/requestleave', this.source).subscribe({
      next: response => {
        alert('Leave request submitted!');

      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
  }
}
