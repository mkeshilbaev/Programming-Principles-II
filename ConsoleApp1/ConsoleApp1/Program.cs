using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string[] arr = s.Split(' ');

            foreach(string i in arr)
            {
                Console.Write(int.Parse(i) + " ");
            }
        }
    }
}
