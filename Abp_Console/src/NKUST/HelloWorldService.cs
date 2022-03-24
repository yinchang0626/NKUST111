using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Abstractions;
using Volo.Abp.DependencyInjection;
using System.Linq;

namespace NKUST;

public class HelloWorldService : ITransientDependency
{
    public ILogger<HelloWorldService> Logger { get; set; }

    public SemesterService SemesterService { get; set; }

    public HelloWorldService()
    {
        Logger = NullLogger<HelloWorldService>.Instance;

        SemesterService=new SemesterService();
    }

    public Task SayHelloAsync()
    {
        Enumerable
            .Range(1, 10)
            .ToList()
            .ForEach(i =>
            {
                SemesterService.AddStudent(new Student()
                {
                    No=System.DateTime.Now.Millisecond.ToString(),
                    FullName="Chang-"+i.ToString()
                });
            });

        SemesterService.PrintStudentName();





        Logger.LogInformation("Hello World!");
        return Task.CompletedTask;
    }
}
