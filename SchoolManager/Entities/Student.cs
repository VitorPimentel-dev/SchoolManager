using System;
using System.Collections.Generic;
using System.Globalization;

namespace SchoolManager.Entities
{
    internal class Student: Person
    {
        public int P1 { get; private set; }
        public int P2 { get; private set; }
        public int P3 { get; private set; }

        public Student()
        {

        }
        public Student (int id,string name,int p1,int p2,int p3):base(id,name)
        {
            P1 = p1;
            P2 = p2;
            P3 = p3;
            Id = id;
            Name = name;
        }
        public double Media()
        {
            int soma = P1 + P2 + P3;
            return (double)soma / 3;
        }
        public override string ToString()
        {
            return $"{Id},{Name}, Media = {Media().ToString("F2", CultureInfo.InvariantCulture)}";
        }

    }
}
