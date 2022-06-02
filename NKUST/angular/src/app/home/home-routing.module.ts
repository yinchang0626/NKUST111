import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home.component';
import { ApplicationLayoutComponent } from '@abp/ng.theme.basic';
import { CoursesComponent } from './components/courses/courses.component';

const routes: Routes = [
  { path: 'courses', component: CoursesComponent },
  { path: '', component: HomeComponent }
 
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule],
})
export class HomeRoutingModule {}
