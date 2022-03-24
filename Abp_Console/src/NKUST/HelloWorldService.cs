using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.DependencyInjection;
using System.Linq;
using System;

namespace NKUST;

public class HelloWorldService : ITransientDependency
{
    private readonly ISemesterService semesterService;

    public ILogger<HelloWorldService> Logger { get; set; }

    public HelloWorldService(
        ISemesterService semesterService
        )
    {
        Logger = NullLogger<HelloWorldService>.Instance;
        this.semesterService=semesterService;
    }

    public Task SayHelloAsync()
    {
        Enumerable
            .Range(1, 10)
            .ToList()
            .ForEach(i =>
            {
                semesterService.AddStudent(new Student()
                {
                    No=System.DateTime.Now.Millisecond.ToString(),
                    FullName="Chang-"+i.ToString()
                });
            });

        semesterService.PrintStudentName();


        


        Logger.LogInformation("Hello World!");
        return Task.CompletedTask;
    }
}
