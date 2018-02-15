using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRIMEex
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] num = line.Split();
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int res = a + b;

            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
