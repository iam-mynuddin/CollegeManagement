import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'otpvalidation',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})
export class HomeComponent implements OnInit {
  homeDetails: any;
  scrollingText: any;
  constructor(private http:HttpClient) { }

  ngOnInit() {
    this.getHomeDetails();
  }

  getHomeDetails() {
    this.http.get('https://localhost:7141/api/home/homepagedetails').subscribe({
      next: result => {
        this.homeDetails = result;
        if (Array.isArray(result)) {
        const scrollingNotification = this.homeDetails.find((item: any) => item.key === "ScrollingNotification");
        if (scrollingNotification) {
          this.scrollingText = scrollingNotification.value;
        }
        }
      },
      error: error => { console.error(error); }
    }
    );
  }
}
