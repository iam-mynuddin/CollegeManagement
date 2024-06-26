import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';
import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { RouterModule } from '@angular/router';


import { HomeComponent } from './home/home.component';
import { ParentComponent } from './parent/parent.component';
import { FacultyComponent } from './faculty/faculty.component';
import { AdminComponent } from './admin/admin.component';
import { StudentComponent } from './student/student.component';

import { FormsModule, ReactiveFormsModule } from '@angular/forms';

import { AuthService } from './_services/auth.service';
import { UserloginComponent } from './userlogin/userlogin.component';
import { AddCalenderComponent } from './add-calender/add-calender.component';
import { ViewCalenderComponent } from './view-calender/view-calender.component';
import { AddAssignmentComponent } from './add-assignment/add-assignment.component';
import { AddAttendanceComponent } from './add-attendance/add-attendance.component';
import { AddIssueComponent } from './add-issue/add-issue.component';
import { AddFeesDetailsComponent } from './add-fees-details/add-fees-details.component';
import { LeaveRequestComponent } from './leave-request/leave-request.component';
import { ViewAssignmentComponent } from './view-assignment/view-assignment.component';
import { ViewAttendanceComponent } from './view-attendance/view-attendance.component';
import { ViewIssueComponent } from './view-issue/view-issue.component';
import { ViewFeeDetailsComponent } from './view-fee-details/view-fee-details.component';
import { ViewLeaveComponent } from './view-leave/view-leave.component';
import { LeaveHistoryComponent } from './leave-history/leave-history.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { SuperSecretComponent } from './super-secret/super-secret.component';
import { AccountComponent } from './account/account.component';
import { RegisterComponent } from './register/register.component';
import { DashboardComponent } from './dashboard/dashboard.component';

import { StudentModule } from './student/student.module';
import { ParentModule } from './parent/parent.module';
import { AdminModule } from './admin/admin.module';
import { FacultyModule } from './faculty/faculty.module';

import { StudentRoutingModule } from './student/student-routing.module';
import { ParentRoutingModule } from './parent/parent-routing.module';
import { AdminRoutingModule } from './admin/admin-routing.module';
import { FacultyRoutingModule } from './faculty/faculty-routing.module';
import { SubmitAssignmentComponent } from './submit-assignment/submit-assignment.component';

@NgModule({
  declarations: [
    AppComponent,
    UserloginComponent,
    HomeComponent,
    StudentComponent,
    ParentComponent,
    FacultyComponent,
    AdminComponent,
    AddCalenderComponent,
    ViewCalenderComponent,
    AddAssignmentComponent,
    AddAttendanceComponent,
    AddIssueComponent,
    AddFeesDetailsComponent,
    LeaveRequestComponent,
    ViewAssignmentComponent,
    ViewAttendanceComponent,
    ViewIssueComponent,
    ViewFeeDetailsComponent,
    ViewLeaveComponent,
    LeaveHistoryComponent,
    SuperSecretComponent,
    AccountComponent,
    RegisterComponent,
    DashboardComponent,
    SubmitAssignmentComponent
  ],
  imports: [
    BrowserModule,
    FormsModule,
    ReactiveFormsModule,
    AppRoutingModule,
    RouterModule,
    HttpClientModule,
    BrowserAnimationsModule,
    StudentRoutingModule,
    ParentRoutingModule,
    FacultyRoutingModule,
    AdminRoutingModule,
    AppRoutingModule,
  ],
  providers: [AuthService],
  bootstrap: [AppComponent]
})
export class AppModule { }
