using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WorkWithStreams
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\input.txt");
            string s = sr.ReadLine();
            string[] arr = s.Split();
            int[] num = new int[arr.Length];
         
            int min1 = Math.Min(num[0], num[1]);
            int min2 = Math.Max(num[0], num[1]);

            for (int i = 0; i < arr.Length; i++)
            {
                if (min1 > num[i])
                {
                    min1 = min2;
                    min1 = num[i];
                }
                if (num[i] < min2 && num[i] > min1)
                    min2 = num[i];                 
            }
            
          // Console.WriteLine(min2);
            sr.Close();

            StreamWriter sw = new StreamWriter(@"D:\output.txt");
            sw.Write(min2);
            sw.Close();
            
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
