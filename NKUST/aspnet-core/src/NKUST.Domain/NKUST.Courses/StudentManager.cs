using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKUST.Courses
{
    public class StudentManager:Volo.Abp.Domain.Services.DomainService
    {
        private readonly ICourseRepository courseRepository;
        private readonly IStudentRepository studentRepository;

        public StudentManager(
            NKUST.Courses.ICourseRepository courseRepository,
            NKUST.Courses.IStudentRepository studentRepository
            ) 
        {
            this.courseRepository=courseRepository;
            this.studentRepository=studentRepository;
        }
        public async Task AddCourse(string studentNo,Guid courseId) 
        {
            var student = await studentRepository.FindByNoAsync(studentNo);

            var course = await courseRepository.FindAsync(courseId);

            if (course == null || student==null)

                throw new Exception("course or student not found");

            student.AddCourse(course);

            await studentRepository.UpdateAsync(student);

        }
    }
}
