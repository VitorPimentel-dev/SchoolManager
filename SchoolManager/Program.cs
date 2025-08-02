using System;
using System.Globalization;
using SchoolManager.Entities;
using SchoolManager.Services;

namespace SchoolManager
{
    class Program
    {
        static void Main(string[] args)
        {
           Menu menu = new Menu();
           menu.Run();
        }
    }
}
