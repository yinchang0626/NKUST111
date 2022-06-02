import type { CourseDto } from './dtos/models';
import { RestService } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class CoursesService {
  apiName = 'Default';

  getFindBy = (schoolName: string) =>
    this.restService.request<any, CourseDto[]>({
      method: 'GET',
      url: '/api/app/courses/find-by',
      params: { schoolName },
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
