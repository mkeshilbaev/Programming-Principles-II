using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNum
{
    class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string[] num = line.Split(' ');
            for (int i = 0; i < num.Length; i++)
            {
                int n = int.Parse(num[i]);
                bool isPrime = true;
                if (n == 1)
                {
                    continue;
                }
                for (int j = 2; j <= Math.Sqrt(n); j++)
                {
                    if (n % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(n);
                }
            }
            Console.ReadKey();
        }
    }
}
