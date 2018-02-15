using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Змейка
{
    class Program
    {
        public static bool gameOver;
        public static int width = 20;
        public static int height = 20;
        public static int x, y, FruitX, FruitY, score;
        public static int tailX[100], tailY[100];
        public static int nTail;
        //enum eDirection {STOP = 0, LEFT, RIGHT, UP, DOWN};
        //eDirection dir;

        public static void Setup()
        {
            gameOver = false;
           // dir = STOP;
            x = width / 2 - 1;
            y = height / 2 - 1;
            FruitX = Random() % width;
            FruitY = Random() % height;
            score = 0;
        }
        
        public static void Draw()
        {
            BackgroundColor = ConsoleColor.DarkBlue;
            ForegroundColor = ConsoleColor.Yellow;
            Console.Clear();
            for (int i = 0; i < width +1; i++)     
                WriteLine("#");

            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == 0 || j < width -1)
                        WriteLine("#");
                    if (i == y && j == x)
                        WriteLine("0");
                    else if (i == fruitY && j == fruitX)
                        Write("F");
                    else
                    {
                        bool print = false;
                        for (int k = 0; k < nTail; k++)
                        {
                            if (tailX[k] == j && tailY[k] == i)
                            {

                                print = true;
                                Write("0");
                            }
                        }
                        if (!print)
                        Write(" ");
                    }
                        
                    
                }
            }

            for (int i = 0; i < width +1; i++)
                WriteLine("#");
            WriteLine("Score: " + score);
            
        }

        public static void Input()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            if (keyInfo.Key == ConsoleKey.LeftArrow);
               x--;
              
            if (keyInfo.Key == ConsoleKey.RightArrow)           
                x++;

            if (keyInfo.Key == ConsoleKey.UpArrow);
                y--;

            if (keyInfo.Key == ConsoleKey.DownArrow)
                y++;

            if (x > width || x < 0 || y > height || y < 0)
                gameOver = true;

            for (int i = 0; i < nTail; i++)
            {
                if (tailX[i] == x && tailY[i] == y)
                    gameOver = true;
            }

            if (x == FruitX && y == FruitY)
            {
                score += 10;
                FruitX = Random() % width;
                FruitY = Random() % height;
                nTail++;
            }
               
            
        }

        public static void Logic()
        {
            int prevX = tailX[0];
            int prevY = tailY[0];
            int prev2X, prev2Y;
            tailX[0] = x;
            tailY[0] = y;

            for (int i = 1; i < nTail; i++)
            {
                prex2X = tailX[i];
                prev2Y = tailY[i];
                tailX[i] = prevX[i];
                tailY[i] = prexY[i];
                prevX = prev2X;
                prevY = prev2Y;
            }
        }

        static void Main(string[] args)
        {
          //  Setup();
          while (!gameOver)
            {
                Draw();
                Input();
                Logic();
            }

        }
    }
}
