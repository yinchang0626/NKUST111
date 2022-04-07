using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKUST.Courses
{
    public interface ICourseRepository:Volo.Abp.Domain.Repositories.IRepository<Course,Guid>
    {

        List<Course> FindBySchoolName(string name);
    }
}
