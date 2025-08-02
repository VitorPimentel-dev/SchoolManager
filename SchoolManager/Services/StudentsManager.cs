
using SchoolManager.Entities;

namespace SchoolManager.Services
{
    internal class StudentsManager:IManager<Student>
    {
        Dictionary<int,Student> students = new Dictionary<int,Student>();
        public void PrintAll()
        {
            foreach (var student in students.Values)
            {
                Console.WriteLine(student);
            }
        }
        public bool TryAdd(Student student)
        {
            return students.TryAdd(student.Id, student);
        }
        public Dictionary<int,Student> GetAll()
        {
            return students;
        }
    }
}
