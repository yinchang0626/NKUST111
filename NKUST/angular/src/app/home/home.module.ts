import { NgModule } from '@angular/core';
import { SharedModule } from '../shared/shared.module';
import { HomeRoutingModule } from './home-routing.module';
import { HomeComponent } from './home.component';
import { CoursesComponent } from './components/courses/courses.component';
import { StudentsComponent } from './components/students/students.component';

@NgModule({
  declarations: [HomeComponent, CoursesComponent, StudentsComponent],
  imports: [SharedModule, HomeRoutingModule],
})
export class HomeModule {}
