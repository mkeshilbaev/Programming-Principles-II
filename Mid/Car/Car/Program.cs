using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Car
{
    class Program // 1-2 are working
    {
        static Car car = new Car();
        static int index = 1;
        int direction = 1;
        static int speed = 0;
        static int XDim;
        static int YDim;

        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader(@"D:\input.txt");
            string s = sr.ReadToEnd();
            string[] arr = s.Split('\n', ' ');
            int[] n = new int[arr.Length];
            for (int i = 0; i <= arr.Length; i++)
            {
                index = n[0];
                XDim = n[1];
                YDim = n[2];
                speed = n[3];
            }
            sr.Close();

            StreamWriter sw = new StreamWriter(@"D:\output.txt");
            sw.WriteLine(index);
            sw.Close();

          
            Console.SetWindowSize(30, 70);
            ConsoleKeyInfo keyInfo = Console.ReadKey();
  
            car.Draw();
            Console.ReadKey();
        }
    }
}
