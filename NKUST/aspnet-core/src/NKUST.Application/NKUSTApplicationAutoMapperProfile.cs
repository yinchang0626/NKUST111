﻿using AutoMapper;
using NKUST.Courses;
using NKUST.Courses.Dtos;

namespace NKUST;

public class NKUSTApplicationAutoMapperProfile : Profile
{
    public NKUSTApplicationAutoMapperProfile()
    {

        this.CreateMap<Course, CourseDto>();

        this.CreateMap<Student, GetStudentDto>();
        this.CreateMap<CreateOrUpdateStudentDto, Student>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
