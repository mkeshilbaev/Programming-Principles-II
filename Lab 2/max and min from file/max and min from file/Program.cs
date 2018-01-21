using System;
using System.IO;
using System.Collections;

namespace max_and_min_from_file
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader SR = new StreamReader("d:\\input.txt");
            string s = SR.ReadLine();
            string[] arr = s.Split();
            int[] a = new int[arr.Length];
            
            for (int i = 0; i < arr.Length; i++)
            {
                a[i] = int.Parse(arr[i]);
            }

            int mx = a[0];
            for(int i = 0; i < arr.Length; i++)
            {
                if (mx < a[i])
                {
                    mx = a[i];
                }
            }
            Console.WriteLine(mx);

            int mn = a[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (mn > a[i])
                {

                }
            }
            Console.WriteLine(mn);

            //SR.Close();

            //foreach (string sOutput in arr)
                //Console.WriteLine(sOutput);
            Console.ReadLine();
        }
    }
}
