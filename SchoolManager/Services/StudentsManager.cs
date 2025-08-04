
using SchoolManager.Entities;

namespace SchoolManager.Services
{
    internal class StudentsManager:IManager<Student>
    {
        private Dictionary<int,Student> _students = new Dictionary<int,Student>();
        public void PrintAll()
        {
            foreach (var student in _students.Values)
            {
                Console.WriteLine(student);
            }
        }
        public bool TryAdd(Student student)
        {
            return _students.TryAdd(student.Id, student);
        }
        public Dictionary<int,Student> GetAll()
        {
            return _students;
        }

        public bool Remove(int id)
        {
            return _students.Remove(id);
        }
        public bool IsEmpty()
        {
            return _students.Count == 0;
        }
    }
}
