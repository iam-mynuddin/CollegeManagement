import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { RouterModule, Routes } from '@angular/router';
import { ViewCalenderComponent } from '../view-calender/view-calender.component';
import { ViewAssignmentComponent } from '../view-assignment/view-assignment.component';
import { ViewAttendanceComponent } from '../view-attendance/view-attendance.component';
import { ViewFeeDetailsComponent } from '../view-fee-details/view-fee-details.component';
import { LeaveHistoryComponent } from '../leave-history/leave-history.component';
import { ViewIssueComponent } from '../view-issue/view-issue.component';
import { ViewLeaveComponent } from '../view-leave/view-leave.component';
import { LeaveRequestComponent } from '../leave-request/leave-request.component';
import { FacultyComponent } from './faculty.component';
import { DashboardComponent } from '../dashboard/dashboard.component';
import { AccountComponent } from '../account/account.component';
import { AddAttendanceComponent } from '../add-attendance/add-attendance.component';
import { AddAssignmentComponent } from '../add-assignment/add-assignment.component';
import { AddIssueComponent } from '../add-issue/add-issue.component';


const routes: Routes = [
  {
    path: 'faculty', component: FacultyComponent, children: [
      { path: 'viewcalender', component: ViewCalenderComponent },
      { path: 'viewassignment', component: ViewAssignmentComponent },
      { path: 'viewattendance', component: ViewAttendanceComponent },
      { path: 'viewfeedetails', component: ViewFeeDetailsComponent },
      { path: 'viewissue', component: ViewIssueComponent },
      { path: 'viewleave', component: ViewLeaveComponent },
      { path: 'leaverequest', component: LeaveRequestComponent },
      { path: 'leavehistory', component: LeaveHistoryComponent },
      { path: 'addattendance', component: AddAttendanceComponent },
      { path: 'addassignment', component: AddAssignmentComponent },
      { path: 'addissue', component: AddIssueComponent },
      { path: 'account',component:AccountComponent},
      { path: '',  component: DashboardComponent }
    ]
  },
];


@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class FacultyRoutingModule { }
