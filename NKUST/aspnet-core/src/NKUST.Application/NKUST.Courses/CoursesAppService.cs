using NKUST.Courses.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKUST.Courses
{
    public class CoursesAppService: 
        NKUSTAppService,
        ICoursesAppService
    {
        private readonly ICourseRepository courseRepository;

        public CoursesAppService(
            ICourseRepository courseRepository
            ) 
        {
            this.courseRepository=courseRepository;
        }

        public async Task<List<CourseDto>> GetFindByAsync(string schoolName) 
        {
            var entities =await courseRepository.FindBySchoolNameAsync(schoolName);

            return this.ObjectMapper.Map<List<Course>,List<CourseDto>>(entities);
        }

    }
}
