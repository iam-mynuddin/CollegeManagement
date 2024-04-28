import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { GetDataService } from '../_services/get-data.service';
import { Assignment, AssignmentSubmission } from '../_models/models';

@Component({
  selector: 'app-submit-assignment',
  templateUrl: './submit-assignment.component.html',
  styleUrls: ['./submit-assignment.component.css']
})
export class SubmitAssignmentComponent {
  source?: any = {} ;
  questionDesc?: string ;
  students: any;
  allUsers: any;
  allSubjects: any;
  allCourses: any;
  pendingAssignments: any;
  constructor(private http: HttpClient, private getData: GetDataService) {
  }

  ngOnInit(): void {
    this.getPendingAssignments();
    this.getData.getAllStudents().subscribe(result => { this.students = result; })
    this.getData.getAllUsers().subscribe(result => { this.allUsers = result; })
    this.getData.getAllCourses().subscribe(result => { this.allCourses = result; })
    this.getData.getAllSubjects().subscribe(result => { this.allSubjects = result; })
  }
  getPendingAssignments() {
    this.http.get('https://localhost:7141/api/assignment/getpendingassignments').subscribe({
      next: response => {
        this.pendingAssignments = response;
      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    }
    ) 
  }
  submitToServer() {
    this.http.post('https://localhost:7141/api/submission/submitassignment', this.source).subscribe({
      next: response => {
        alert('Assignment submitted!');

      },
      error: error => {
        alert('Error! check console!');
        console.log(error);
      }
    });
  }
  updateDropdowns(selectedOption: any) {
    let selectedQuestion: any;
    selectedQuestion = this.pendingAssignments.find((u: { assignmentId: any; }) => u.assignmentId == selectedOption);    
    this.source.courseId = selectedQuestion.courseId;
    this.source.subjectId = selectedQuestion.subjectId;
    this.source.studentId = selectedQuestion.studentId;
  }
}
