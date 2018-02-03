using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] num1 = s.Split(' ');
            string[] n1 = num1[0].Split('/');
            string[] n2 = num1[1].Split('/');

            int i1 = int.Parse(n1[0]);
            int i2 = int.Parse(n1[1]);
            int i3 = int.Parse(n2[0]);
            int i4 = int.Parse(n2[1]);

            Complex c1 = new Complex(i1, i2);
            Complex c2 = new Complex(i3, i4);
            Complex mul = c1 * c2;
            Complex div = c1 / c2;
            Complex sum = c1 + c2;
            Complex sub = c1 - c2;

            Console.WriteLine("Multiplication of these two numbers: " + mul);
            Console.WriteLine("Division of these two numbers: " + div);
            Console.WriteLine("Sum of these two numbers: " + sum);
            Console.WriteLine("Subtraction of these two numbers: " + sub);
        }
    }
}
