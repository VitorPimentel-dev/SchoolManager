using SchoolManager.Entities;
using System.Globalization;
using System.Xml.Linq;

namespace SchoolManager.Services
{
    internal class TeacherManager : IManager<Teacher>
    {
        Dictionary<int, Teacher> teachers = new Dictionary<int, Teacher>();
        public TeacherManager()
        {
        }
        public bool TryAdd(Teacher teacher)
        {
            return teachers.TryAdd(teacher.Id, teacher);
        }
        public bool Remove(int id)
        {
            return teachers.Remove(id);
        }
        public Dictionary<int, Teacher> GetAll()
        {
            return teachers;
        }
        public void PrintAll()
        {
            foreach(var teacher in teachers.Values)
            {
                Console.WriteLine(teacher);
            }
        }
        public bool IsEmpty()
        {
            return teachers.Count == 0;
        }
    }
}
