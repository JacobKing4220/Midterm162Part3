uusing System;
using System.Diagnostics;
using ProfessorClasses;
using static System.Net.Mime.MediaTypeNames;

namespace CustomerProductTests
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteProf();
        }

        static void WriteProf()
        {
            Professor p1 = new Professor("L", "Brad", "Bird", "Computer Science");
            Console.WriteLine(p1.ToString());
        }

    }
}