using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;

namespace Snake
{
    class Wall
    {
        static void Walls()
        {
            for (int i = 0; i < WindowWidth; i++)
            {
                SetCursorPosition(i, 0);
                Write("■");

                SetCursorPosition(i, WindowHeight - 1);
                Write("■");
            }

            for (int i = 0; i < WindowHeight; i++)
            {
                SetCursorPosition(0, i);
                Write("■");

                SetCursorPosition(WindowWidth - 1, i);
                Write("■");
            }
        }
    }
}
