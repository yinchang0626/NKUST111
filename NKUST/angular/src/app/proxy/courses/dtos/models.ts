import type { EntityDto } from '@abp/ng.core';

export interface CourseDto {
  開課年度?: string;
  開課學期?: string;
  校名?: string;
  課程名稱?: string;
  系所名稱?: string;
  年級?: string;
  開課老師?: string;
  學分數?: string;
  學制?: string;
  必選修?: string;
  總修課人數?: string;
}

export interface CreateOrUpdateStudentDto {
  name?: string;
  no?: string;
}

export interface GetStudentDto extends EntityDto<string> {
  name?: string;
  no?: string;
  className?: string;
}
