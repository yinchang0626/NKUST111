using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace NKUST.Courses
{
    public class CoursesManager : ITransientDependency
    {

        public async Task<List<Course>> ReadFileAsync(int count = int.MaxValue)
        {
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

                var item = new Course();

                headerColumns.ForEach(column =>
                {
                    try
                    {
                        var index = headerColumns.IndexOf(column);

                        var propertyInfo = typeof(Course).GetProperty(column);

                        if (datas.Length>=index+1)
                        {
                            propertyInfo.SetValue(item, datas[index]);
                        }
                    }
                    catch (Exception ex)
                    {

                    }

                });

                return item;

                //return new Course()
                //{
                //    開課年度= datas[0],
                //    開課學期= datas[1],
                //    校名= datas[2],
                //    課程名稱= datas[3],
                //    系所名稱= datas[4],
                //    年級= datas[5],
                //    開課老師= datas[6],
                //    學分數= datas[7],
                //    學制= datas[8],
                //    必選修= datas[9],
                //    總修課人數=datas[10]
                //};

            }).ToList();




            return result;

        }
    }
}
