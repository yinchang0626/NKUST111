using NKUST.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.EntityFrameworkCore;

namespace NKUST.Courses
{
    public class EfCoreCourseRepository
        :Volo.Abp.Domain.Repositories.EntityFrameworkCore.EfCoreRepository<
            NKUSTDbContext,Course,Guid>,
        ICourseRepository
    {

        public EfCoreCourseRepository(
            IDbContextProvider<NKUSTDbContext> dbContextProvider)
            : base(dbContextProvider)
        {
            
        }


        public List<Course> FindBySchoolName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
