import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-fees-details',
  templateUrl: './add-fees-details.component.html',
  styleUrls: ['./add-fees-details.component.css']
})
export class AddFeesDetailsComponent implements OnInit {
  feesdetail:any;

  constructor(private http:HttpClient,private fb :FormBuilder) {
    this.feesdetail=this.fb.group({
      StudentId:['',[Validators.required]],
      Amount:['',[Validators.required]],
      DateOfPayment:['',[Validators.required]]
    
    });
   }

  ngOnInit(): void {
  }

  addfeesdetails(){
    const fs={
      StudentId:this.feesdetail.get("StudentId")?.value,
      Amount:this.feesdetail.get("Amount")?.value,
      DateOfPayment:this.feesdetail.get("DateOfPayment")?.value
    }
    this.http.post('https://localhost:7141/api/fee/uploadfeedetails', fs).subscribe(
      (data)=>{alert('saved successfully');},
      (err)=>{console.log(err);
        alert('Error saving data');
    });
        
    
  }

}
