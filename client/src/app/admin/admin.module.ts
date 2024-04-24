import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AdminRoutingModule } from './admin-routing.module';
import { RouterModule } from '@angular/router';
import { AdminComponent } from './admin.component';


@NgModule({
  declarations: [
  ],
  imports: [
    CommonModule,
    RouterModule,
    AdminRoutingModule
  ],
})
export class AdminModule { }
