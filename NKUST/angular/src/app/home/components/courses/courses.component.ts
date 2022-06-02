import { Component, OnInit } from '@angular/core';
import { StudentCrudService } from '@proxy/courses/student-crud.service';
import { CoursesService } from '@proxy/courses/courses.service';
import { CourseDto } from '@proxy/courses/dtos';

@Component({
  selector: 'app-courses',
  templateUrl: './courses.component.html',
  styles: [],
})
export class CoursesComponent implements OnInit {
  datas: CourseDto[] = [];
  schoolNameInput:string ='';

  constructor(
    private coursesService: CoursesService,
    private studentCrudService :StudentCrudService
    )
     {}

  ngOnInit(): void {

  }

  search(){
    this.coursesService.getFindBy(this.schoolNameInput).subscribe(json => {
      this.datas = json;
    });


  }
}
