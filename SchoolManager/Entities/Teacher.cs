
namespace SchoolManager.Entities
{
    internal class Teacher : Person
    {
        public double MonthlySalary { get; private set; }
        public int ClassInWeek { get; private set; }
        public Teacher() 
        {
            
        }
        public Teacher(int id, string name, double monthlySalary, int classInWeek) : base(id, name)
        {
            MonthlySalary = monthlySalary;
            ClassInWeek = classInWeek;
        }
        public override string ToString()
        {
            return $"{Id},{Name}, salário: {MonthlySalary}";
        }
    }
}
