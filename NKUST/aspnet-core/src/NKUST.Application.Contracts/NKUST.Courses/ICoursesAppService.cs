using NKUST.Courses.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NKUST.Courses
{
    public interface ICoursesAppService
    {
        Task<List<CourseDto>> GetFindByAsync(string schoolName);

    }
}
