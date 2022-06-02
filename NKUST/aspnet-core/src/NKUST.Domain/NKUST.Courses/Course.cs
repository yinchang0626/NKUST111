using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKUST.Courses
{
    public class Course : Volo.Abp.Domain.Entities.Auditing.FullAuditedAggregateRoot<Guid>
    {
        public string 開課年度 { get; set; }
        public string 開課學期 { get; set; }
        public string 校名 { get; set; }
        public string 課程名稱 { get; set; }
        public string 系所名稱 { get; set; }
        public string 年級 { get; set; }
        public string 開課老師 { get; set; }
        public string 學分數 { get; set; }
        public string 學制 { get; set; }
        public string 必選修 { get; set; }
        public string 總修課人數 { get; set; }

        public virtual ICollection<StudentCourse> StudentCourses { get; set; }

        public override string ToString()
        {
            return $"{校名}-{開課老師}-{系所名稱}-{課程名稱}";
        }


        public Course(Guid id)
        {
            this.Id=id;
        }
    }
}
