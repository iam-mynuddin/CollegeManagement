import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { StudentRoutingModule } from './student-routing.module';
import { RouterModule } from '@angular/router';
import { StudentComponent } from './student.component';


@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    RouterModule,
    StudentRoutingModule
  ],
})
export class StudentModule { }
