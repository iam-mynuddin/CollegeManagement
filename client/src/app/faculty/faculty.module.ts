import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { facultyRoutingModule } from './faculty-routing.module';
import { RouterModule } from '@angular/router';
import { FacultyComponent } from './faculty.component';


@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    RouterModule,
    facultyRoutingModule
  ],
})
export class FacultyModule { }
