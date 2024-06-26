import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { AddAssignmentComponent } from './add-assignment/add-assignment.component';
import { AddAttendanceComponent } from './add-attendance/add-attendance.component';
import { AddCalenderComponent } from './add-calender/add-calender.component';
import { AddFeesDetailsComponent } from './add-fees-details/add-fees-details.component';
import { AddIssueComponent } from './add-issue/add-issue.component';
import { AdminComponent } from './admin/admin.component';
import { AppComponent } from './app.component';

import { FacultyComponent } from './faculty/faculty.component';
import { HomeComponent } from './home/home.component';
import { LeaveHistoryComponent } from './leave-history/leave-history.component';
import { LeaveRequestComponent } from './leave-request/leave-request.component';

import { ParentComponent } from './parent/parent.component';
import { StudentComponent } from './student/student.component';
import { UserloginComponent } from './userlogin/userlogin.component';
import { ViewAssignmentComponent } from './view-assignment/view-assignment.component';
import { ViewAttendanceComponent } from './view-attendance/view-attendance.component';
import { ViewCalenderComponent } from './view-calender/view-calender.component';
import { ViewFeeDetailsComponent } from './view-fee-details/view-fee-details.component';
import { ViewIssueComponent } from './view-issue/view-issue.component';
import { ViewLeaveComponent } from './view-leave/view-leave.component';
import { SuperSecretComponent } from './super-secret/super-secret.component';
import { RegisterComponent } from './register/register.component';
import { SubmitAssignmentComponent } from './submit-assignment/submit-assignment.component';
import { AccountComponent } from './account/account.component';



const routes: Routes = [
  {path:'app',component:AppComponent},
  {path:'userlogin',component:UserloginComponent},
  {path:'home',component:HomeComponent},
  //{path:'student',component:StudentComponent},
  //{path:'admin',component:AdminComponent},
  //{path:'faculty',component:FacultyComponent},
  //{path:'parent',component:ParentComponent},
  {path:'addcalender',component:AddCalenderComponent},
  {path:'viewcalender',component:ViewCalenderComponent},
  {path:'addattendance',component:AddAttendanceComponent},
  {path:'addfeesdetails',component:AddFeesDetailsComponent},
  {path:'addissue',component:AddIssueComponent},
  {path:'viewassignment',component:ViewAssignmentComponent},
  {path:'viewattendance',component:ViewAttendanceComponent},
  {path:'viewfeedetails',component:ViewFeeDetailsComponent},
  {path:'viewissue',component:ViewIssueComponent},
  {path:'viewleave',component:ViewLeaveComponent},
  {path:'addassignment',component:AddAssignmentComponent},
  {path:'leaverequest',component:LeaveRequestComponent},
  {path:'leavehistory',component:LeaveHistoryComponent},
  {path:'supersecret',component:SuperSecretComponent},
  {path:'register', component: RegisterComponent },  
  {path:'submitassigment', component: SubmitAssignmentComponent },  
  {path:'account', component: AccountComponent },  
  { path: '', redirectTo: 'home', pathMatch: 'full' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
