using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Threading;

namespace Mid2
{
    class Program
    {
        public static int n, cnt = 0;
        public int direction = 1; // 1-left, 2-right, 3-up, 4-down
        static Packman packman = new Packman();

        public void ReadAll()
        {
            StreamReader sr = new StreamReader("input.txt");
            int n = int.Parse(sr.ReadLine());
            string s = sr.ReadLine();

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '*')
                    wall.Add();

                if (s[i] == '.')
                    empty.packman.Add();

                if (s[i] == 'f')
                    food.Add();
            
                sr.Close();
            }
        }

        static void MovePackman(object Game)
        {
            while (true)
            {
                Console.Clear();
                //packman.Draw();

                for (int i = 0; i < n; i++)
                {

                }
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {          


           // Thread t = new Thread();
           // t.Start();

            ConsoleKeyInfo keyInfo = Console.ReadKey();
             

        }
    }
}
