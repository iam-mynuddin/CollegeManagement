import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add-assignment',
  templateUrl: './add-assignment.component.html',
  styleUrls: ['./add-assignment.component.css']
})
export class AddAssignmentComponent implements OnInit {
  
  //assignment:any;
  assignment:any;

constructor(private http:HttpClient,private fb :FormBuilder) {
  this.assignment=this.fb.group({
    AssignmentId:['',[Validators.required]],
    StudentId:['',[Validators.required]],
    SubjectCode:['',[Validators.required]],
    SubmissionTime:['',[Validators.required]],
    Question:['',[Validators.required]]
  
  });
 }

ngOnInit(): void {
}

addassignment(){
  const ass={
    AssignmentId:this.assignment.get("AssignmentId")?.value,
    StudentId:this.assignment.get("StudentId")?.value,
    SubjectCode:this.assignment.get("SubjectCode")?.value,
    SubmissionTime:this.assignment.get("SubmissionTime")?.value,
    Question:this.assignment.get("Question")?.value
  }
  this.http.post('https://localhost:7141/api/assignment/uploadassignmentques', ass).subscribe(
    (data)=>{alert('saved successfully');},
    (err)=>{console.log(err);
      alert('Error saving data');
  });
      
  
}

}
