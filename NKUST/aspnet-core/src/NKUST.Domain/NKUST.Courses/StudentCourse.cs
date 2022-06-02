using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKUST.Courses
{
    public class StudentCourse : Volo.Abp.Domain.Entities.Entity
    {
        public Guid StudentId { get; set; }
        public Guid CourseId { get; set; }
        public override object[] GetKeys()
        {
            return new object[] { StudentId, CourseId };
        }
    }
}
