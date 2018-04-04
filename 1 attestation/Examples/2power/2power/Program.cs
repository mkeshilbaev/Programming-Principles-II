using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2power
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int pow = int.Parse(Console.ReadLine());
            double res = 1;

            for (int i = 1; i <= Math.Abs(pow); i++)
            {
                res *= 2; 
            }

            if (pow < 0)
                res = 1 / res;

            if (pow == 0)
                res = 1;

            Console.Write(res);
            Console.ReadKey();
        }
    }
}
