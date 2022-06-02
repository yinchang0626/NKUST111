using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKUST.Courses
{
    public class Student : Volo.Abp.Domain.Entities.Auditing.FullAuditedAggregateRoot<Guid>
    {
        public string Name { get; set; }

        public string No { get; set; }

        public string ClassName { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }

        public Student() { }
        public Student(Guid id,string name, string no)
        {
            Id=id;
            Name=name;
            No=no;
            StudentCourses=new List<StudentCourse>();
        }

        public void AddCourse(Course course)
        {
            var studentCourse = new StudentCourse()
            {
                CourseId=course.Id,
                StudentId=this.Id
            };

            this.StudentCourses.Add(studentCourse);

        }
    }
}
