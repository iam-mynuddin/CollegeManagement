import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { ParentRoutingModule } from './parent-routing.module';
import { RouterModule } from '@angular/router';
import { ParentComponent } from './parent.component';


@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    RouterModule,
    ParentRoutingModule
  ],
})
export class ParentModule { }
