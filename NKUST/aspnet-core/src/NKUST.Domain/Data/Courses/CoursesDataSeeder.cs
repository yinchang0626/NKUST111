using NKUST.Courses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Guids;

namespace NKUST.Data.Courses
{
    public class CoursesDataSeeder : Volo.Abp.DependencyInjection.ISingletonDependency
    {
        private readonly ICourseRepository courseRepository;
        private readonly IGuidGenerator generator;

        public CoursesDataSeeder(
            NKUST.Courses.ICourseRepository courseRepository,
            Volo.Abp.Guids.IGuidGenerator generator
            )
        {
            this.courseRepository=courseRepository;
            this.generator=generator;
        }

        public async Task ImportFromCsv(int count = int.MaxValue)
        {
            var toDeletes=(await courseRepository.GetQueryableAsync()).ToList();

            await courseRepository.DeleteManyAsync(toDeletes,true);

            var result = new List<Course>();

            var basePath = AppDomain.CurrentDomain.BaseDirectory;

            var filePath = System.IO.Path.Combine(basePath, @"Files/大學開課表.csv");

            var lines = await System.IO.File.ReadAllLinesAsync(filePath);

            var headerColumns = lines.First().Split(',').ToList();

            result =lines
                .Skip(1)
                .Take(count)
                .Select(line =>
                {
                    var datas = line.Split(',');

                    if (datas.Length<11)
                        return null;

                    return new Course(this.generator.Create())
                    {
                        開課年度= datas[0],
                        開課學期= datas[1],
                        校名= datas[2],
                        課程名稱= datas[3],
                        系所名稱= datas[4],
                        年級= datas[5],
                        開課老師= datas[6],
                        學分數= datas[7],
                        學制= datas[8],
                        必選修= datas[9],
                        總修課人數=datas[10]
                    };



                })
                .Where(x => x!=null)
                .ToList();


            await courseRepository.InsertManyAsync(result, true);

        }
    }
}
