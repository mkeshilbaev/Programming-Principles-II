using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Svetofor
{
    class Program
    {
        public static void F1()
        {
            int cnt = 0;

            while (true)
            {              
                Console.CursorVisible = false;
                Console.Clear();
                cnt++;

                for (int i = 0; i < 4; i++)
                {
                    if (cnt == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("****");
                }
                Console.WriteLine();

                for (int i = 0; i < 4; i++)
                {
                    if (cnt == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                    }
                    else
                        Console.ForegroundColor = ConsoleColor.White;

                    Console.WriteLine("****");
                }
                Console.WriteLine();

                    for (int i = 0; i < 4; i++)
                    {
                        if (cnt == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                        }
                        else
                            Console.ForegroundColor = ConsoleColor.White;

                        Console.WriteLine("****");
                    }

                if (cnt == 3)
                    cnt = 0;

                Thread.Sleep(1000);                  
                    }
                }

        static void Main(string[] args)
        {          
            Thread thread = new Thread(F1);
            thread.Start();
            Console.ReadKey();
        }
    }
}
