using System;
using System.Collections.Generic;
using System.Text;

namespace NKUST.Courses.Dtos
{
    public class CreateOrUpdateStudentDto 
    {
        public string Name { get; set; }

        public string No { get; set; }
    }

    public class GetStudentDto : Volo.Abp.Application.Dtos.EntityDto<Guid>
    {
        public string Name { get; set; }

        public string No { get; set; }

        public string ClassName { get; set; }
    }
}
