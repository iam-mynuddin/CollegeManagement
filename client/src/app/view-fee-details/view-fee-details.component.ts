import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FeeDetail } from '../_models/feeDetails';

@Component({
  selector: 'app-view-fee-details',
  templateUrl: './view-fee-details.component.html',
  styleUrls: ['./view-fee-details.component.css']
})
export class ViewFeeDetailsComponent implements OnInit {
  
  feedetails: FeeDetail[] = [];

  constructor(private http:HttpClient) { }

  ngOnInit(): void {   
    this.http.get('https://localhost:7141/api/fee/getfeedetails').subscribe({
      next: response => {
        this.feedetails = response as FeeDetail[];
      },
      error: error => {
        alert('error fetching data');
      }
    });
  }
  formatDate(dateString: string): string {
    const dateObject = new Date(dateString);
    const year = dateObject.getFullYear();
    const month = dateObject.getMonth() + 1;
    const day = dateObject.getDate();
    return `${year}-${month.toString().padStart(2, '0')}-${day.toString().padStart(2, '0')}`;
  }
}

