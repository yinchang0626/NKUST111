using NKUST.Courses.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;

namespace NKUST.Courses
{
    //[Volo.Abp.RemoteService(false)]
    //public class StudentsAppService :
    //    Volo.Abp.Application.Services.ApplicationService,
    //    IStudentsAppService
    //{
    //    private readonly Volo.Abp.Domain.Repositories.IRepository<Student, Guid> studentRepository;

    //    public StudentsAppService(
    //        Volo.Abp.Domain.Repositories.IRepository<Student, Guid> studentRepository
    //        )
    //    {
    //        this.studentRepository=studentRepository;
    //    }

    //    public async Task CreateAsync(CreateOrUpdateStudentDto input)
    //    {
    //        var newEntity = new NKUST.Courses.Student(
    //            this.GuidGenerator.Create(),
    //            input.Name, input.No);

    //        await studentRepository.InsertAsync(newEntity, true);

    //    }

    //    public void Update() { }

    //    public void Delete() { }

    //    public void List() { }

    //    public async Task<GetStudentDto> GetAsync(Guid id)
    //    {
    //        var entity = await studentRepository.FindAsync(id);

    //        var dto = new Dtos.GetStudentDto()
    //        {
    //            No=entity.No,
    //            Name=entity.Name,
    //            ClassName=entity.ClassName
    //        };

    //        return dto;
    //    }


    //}


    public class StudentCrudAppService : Volo.Abp.Application.Services.CrudAppService<
        Student,
        Dtos.GetStudentDto,
        Guid,
        PagedAndSortedResultRequestDto,
        Dtos.CreateOrUpdateStudentDto,
        Dtos.CreateOrUpdateStudentDto>,
        IStudentCrudAppService
    {

        protected override Task CheckCreatePolicyAsync()
        {
            return base.CheckCreatePolicyAsync();
        }

        public StudentCrudAppService(
            Volo.Abp.Domain.Repositories.IRepository<Student, Guid> studentRepository
            )
            : base(studentRepository)
        {

        }
    }
    public interface IStudentCrudAppService : Volo.Abp.Application.Services.ICrudAppService<
        Dtos.GetStudentDto, Guid,
        PagedAndSortedResultRequestDto,
        Dtos.CreateOrUpdateStudentDto,
        Dtos.CreateOrUpdateStudentDto>
    { }
}
