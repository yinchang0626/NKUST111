using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NKUST
{
    public class SemesterService
    {
        public SemesterService()
        {
            Students=new List<Student>();
        }

        public List<Student> Students { get; set; }

        public void AddStudent(Student student)
        {
            this.Students.Add(student);
        }

        public void PrintStudentName() 
        {
            Students.ForEach(x =>
            {
                Console.WriteLine($"學生姓名：{x.FullName}");
            });
           
        }
    }
}
