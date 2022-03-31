using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.DependencyInjection;
using System.Linq;
using System;
using NKUST.Courses;

namespace NKUST;

public class HelloWorldService : ITransientDependency
{
    private readonly ISemesterService semesterService;
    private readonly CoursesManager coursesManager;

    public ILogger<HelloWorldService> Logger { get; set; }

    public HelloWorldService(
        ISemesterService semesterService,
        NKUST.Courses.CoursesManager coursesManager
        )
    {
        Logger = NullLogger<HelloWorldService>.Instance;
        this.semesterService=semesterService;
        this.coursesManager=coursesManager;
    }

    public async Task SayHelloAsync()
    {

        var coursees = await coursesManager.ReadFileAsync();


        var schoolCount = coursees.GroupBy(x => x.校名).Count();

        var teacherCount = coursees.GroupBy(x => x.開課老師).Count();

        var s = coursees
            .GroupBy(x => x.校名)
            .Where(x => x.Key.Contains("國立交通大學"))
            .Single();


        var c = s.ToList();


        Logger.LogInformation("Courses Count:"+coursees.Count().ToString());




        coursees.ForEach(x =>
        {
            Logger.LogInformation(x.ToString());
        });


        Logger.LogInformation("Hello World!");
    }
}
