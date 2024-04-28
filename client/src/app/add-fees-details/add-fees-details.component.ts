import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { GetDataService } from '../_services/get-data.service';
import { FeeDetail } from '../_models/models';

@Component({
  selector: 'app-add-fees-details',
  templateUrl: './add-fees-details.component.html',
  styleUrls: ['./add-fees-details.component.css']
})
export class AddFeesDetailsComponent implements OnInit {
  source: any = {};
  students: any;

  constructor(private http: HttpClient, private getData: GetDataService) {
  }

  ngOnInit(): void {
    this.getData.getAllStudents().subscribe(result => { this.students = result; });
  }
  submitToServer() {
    this.http.post('https://localhost:7141/api/fee/addfeedetails', this.source).subscribe({
      next: response => {
        alert('Fee details added!');
      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
  }
}
