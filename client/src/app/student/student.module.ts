import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentRoutingModule } from './student-routing.module';
import { StudentComponent } from './student.component';
import { LeaveHistoryComponent } from '../leave-history/leave-history.component';
import { ViewLeaveComponent } from '../view-leave/view-leave.component';
import { ViewFeeDetailsComponent } from '../view-fee-details/view-fee-details.component';
import { ViewIssueComponent } from '../view-issue/view-issue.component';
import { LeaveRequestComponent } from '../leave-request/leave-request.component';
import { ViewAssignmentComponent } from '../view-assignment/view-assignment.component';
import { ViewAttendanceComponent } from '../view-attendance/view-attendance.component';
import { RouterModule } from '@angular/router';



@NgModule({
  declarations: [
    StudentComponent,
    LeaveRequestComponent,
    ViewAssignmentComponent,
    ViewAttendanceComponent,
    ViewIssueComponent,
    ViewFeeDetailsComponent,
    ViewLeaveComponent,
    LeaveHistoryComponent,
  ],
  imports: [
    CommonModule,
    RouterModule,
    StudentRoutingModule
  ]
})
export class StudentModule { }
