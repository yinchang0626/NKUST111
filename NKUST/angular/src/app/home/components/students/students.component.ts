import { ListService, PagedResultDto } from '@abp/ng.core';
import { ThemeSharedModule } from '@abp/ng.theme.shared';
import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { StudentCrudService } from '@proxy/courses';
import { CreateOrUpdateStudentDto, GetStudentDto } from '@proxy/courses/dtos';
import { textChangeRangeIsUnchanged } from 'typescript';

@Component({
  selector: 'app-students',
  templateUrl: './students.component.html',
  styles: [],
  providers: [ListService],
})
export class StudentsComponent implements OnInit {
  datas: PagedResultDto<GetStudentDto> = {
    items: [],
    totalCount: 0,
  } as PagedResultDto<GetStudentDto>;

  isModalOpen: boolean = false;

  form: FormGroup;

  constructor(
    private studentCrudService: StudentCrudService,
    public list: ListService,
    private fb: FormBuilder
  ) {}

  ngOnInit(): void {
    var query = q => {
      return this.studentCrudService.getList(q);
    };

    this.list.hookToQuery(query).subscribe(json => {
      this.datas = json;
    });
  }
  toCreate(): void {
    this.isModalOpen = true;
    this.form = this.fb.group({ name: [''], no: [''] });
  }

  save(): void {
    this.studentCrudService.create(this.form.value as CreateOrUpdateStudentDto).subscribe(json => {
      this.list.get();
      this.isModalOpen = false;
    });
  }
}
