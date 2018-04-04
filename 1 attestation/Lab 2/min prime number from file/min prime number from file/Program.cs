using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace min_prime_number_from_file
{
    class Program
    {
        public static bool isPrime(int n)
        {
            bool res = true;

            for (int j = 0; j <= n; j++)
            {
                if (n == 1)
                {
                    break;
                }
            }          
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0 )
                {
                    res = false;
                    break;
                }
            }                   
            return res;
        }

        public static int mini = 10000;

        static void Main(string[] args)
        {
            string str = File.ReadAllText(@"d:\\input.txt");

            args = str.Split();

            foreach (string s in args)
            {
                int a = int.Parse(s);
                if (a < mini && mini != 1)
                {
                    if (isPrime(a))
                        mini = a;
                }
            }
            Console.WriteLine(mini + "\n");
            Console.ReadKey();
        }
    }
}