import type { CreateOrUpdateStudentDto, GetStudentDto } from './dtos/models';
import { RestService } from '@abp/ng.core';
import type { PagedAndSortedResultRequestDto, PagedResultDto } from '@abp/ng.core';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root',
})
export class StudentCrudService {
  apiName = 'Default';

  create = (input: CreateOrUpdateStudentDto) =>
    this.restService.request<any, GetStudentDto>({
      method: 'POST',
      url: '/api/app/student-crud',
      body: input,
    },
    { apiName: this.apiName });

  delete = (id: string) =>
    this.restService.request<any, void>({
      method: 'DELETE',
      url: `/api/app/student-crud/${id}`,
    },
    { apiName: this.apiName });

  get = (id: string) =>
    this.restService.request<any, GetStudentDto>({
      method: 'GET',
      url: `/api/app/student-crud/${id}`,
    },
    { apiName: this.apiName });

  getList = (input: PagedAndSortedResultRequestDto) =>
    this.restService.request<any, PagedResultDto<GetStudentDto>>({
      method: 'GET',
      url: '/api/app/student-crud',
      params: { skipCount: input.skipCount, maxResultCount: input.maxResultCount, sorting: input.sorting },
    },
    { apiName: this.apiName });

  update = (id: string, input: CreateOrUpdateStudentDto) =>
    this.restService.request<any, GetStudentDto>({
      method: 'PUT',
      url: `/api/app/student-crud/${id}`,
      body: input,
    },
    { apiName: this.apiName });

  constructor(private restService: RestService) {}
}
