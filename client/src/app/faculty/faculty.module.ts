import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FacultyRoutingModule } from './faculty-routing.module';
import { RouterModule } from '@angular/router';
import { FacultyComponent } from './faculty.component';


@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    RouterModule,
    FacultyRoutingModule
  ],
})
export class FacultyModule { }
