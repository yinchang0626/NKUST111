using NKUST.Courses;
using NKUST.Data.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;

namespace NKUST.Data
{
    public class NKUSTDataSeedContributor : IDataSeedContributor,Volo.Abp.DependencyInjection.ISingletonDependency
    {
        private readonly CoursesDataSeeder coursesDataSeeder;
        private readonly ICourseRepository courseRepository;

        public NKUSTDataSeedContributor(
            CoursesDataSeeder coursesDataSeeder,
            NKUST.Courses.ICourseRepository courseRepository
            )
        {
            this.coursesDataSeeder=coursesDataSeeder;
            this.courseRepository=courseRepository;
        }
        public async Task SeedAsync(DataSeedContext context)
        {
           // await coursesDataSeeder.ImportFromCsv(100);
        }
    }
}
