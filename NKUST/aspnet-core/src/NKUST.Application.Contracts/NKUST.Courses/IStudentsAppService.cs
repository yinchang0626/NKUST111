using NKUST.Courses.Dtos;
using System;
using System.Threading.Tasks;

namespace NKUST.Courses
{
    public interface IStudentsAppService : 
        Volo.Abp.Application.Services.IApplicationService
    {
        Task CreateAsync(CreateOrUpdateStudentDto input);
        void Delete();
        Task<GetStudentDto> GetAsync(Guid id);
        void List();
        void Update();
    }
}