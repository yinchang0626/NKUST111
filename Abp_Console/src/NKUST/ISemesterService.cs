using System.Collections.Generic;

namespace NKUST
{
    public interface ISemesterService
    {
        List<Student> Students { get; set; }

        void AddStudent(Student student);
        void PrintStudentName();
    }
}