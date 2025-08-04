using SchoolManager.Entities;
using System.Globalization;
using System.Xml.Linq;

namespace SchoolManager.Services
{
    internal class TeacherManager : IManager<Teacher>
    {
        private Dictionary<int, Teacher> _teachers = new Dictionary<int, Teacher>();
        public TeacherManager()
        {
        }
        public bool TryAdd(Teacher teacher)
        {
            return _teachers.TryAdd(teacher.Id, teacher);
        }
        public bool Remove(int id)
        {
            return _teachers.Remove(id);
        }
        public Dictionary<int, Teacher> GetAll()
        {
            return _teachers;
        }
        public void PrintAll()
        {
            foreach(var teacher in _teachers.Values)
            {
                Console.WriteLine(teacher);
            }
        }
        public bool IsEmpty()
        {
            return _teachers.Count == 0;
        }
    }
}
