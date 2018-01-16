using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        public string name;
        public string sname;
        public double gpa;

        public Student(string a, string b, double c)
        {
            name = a;
            name = b;
            gpa = c;
        }
        public override string ToString()
        {
            return name + " " + sname + " " + gpa;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            string sname = Console.ReadLine();
            double gpa = Convert.ToDouble(Console.ReadLine());
            Student s = new Student(name, sname, gpa);
            Console.WriteLine(s);
            Console.ReadKey();
        }
    }
}