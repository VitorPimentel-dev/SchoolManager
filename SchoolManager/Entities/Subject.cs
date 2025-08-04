

namespace SchoolManager.Entities
{
    internal class Subject
    {
        public string Name { get; set; }
        public int Code { get; set; }
        public int credits { get; set; }

        public Teacher AssignedTeacher { get; set; }

        public Subject() 
        {
        
        }
        public Subject(string name, int code, int credits, Teacher assignedTeacher)
        {
            Name = name;
            Code = code;
            this.credits = credits;
            AssignedTeacher = assignedTeacher;
        }
    }
}
