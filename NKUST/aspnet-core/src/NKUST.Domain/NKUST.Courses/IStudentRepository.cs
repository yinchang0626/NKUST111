using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKUST.Courses
{
    public interface IStudentRepository : Volo.Abp.Domain.Repositories.IRepository<Student,Guid>
    {

        Task<Student> FindByNoAsync(string no);
    }
}
