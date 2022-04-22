using Microsoft.EntityFrameworkCore;
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


        public async Task<List<Course>> FindBySchoolNameAsync(string name)
        {
            var query = await this.GetQueryableAsync();

            return await query.Where(x => x.校名.Contains(name)).ToListAsync();
        }
    }
}
