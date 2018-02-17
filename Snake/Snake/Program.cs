using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] xPosition = new int[50];
            xPosition[0] = 35;
            int[] yPosition = new int[50];
            yPosition[0] = 10;
            int applesEaten = 0; //counter

            decimal gameSpeed = 150m;

            bool GameOver = false;
            bool isWallHit = false;
            bool isAppleEaten = false;

            Random random = new Random();
            Console.CursorVisible = false;

            // Get the snake on the screean
            PaintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition);

            //Set apple on screen
            SetApplePositionOnScreen(random, out int appleXDim, out int appleYDim);
            PaintApple(appleXDim, appleYDim);

            //Build boundary
            BuildWall();

            //Get snake to move
            ConsoleKey KeyInfo = Console.ReadKey().Key;
            do
            {
                switch (KeyInfo)
                {
                    case ConsoleKey.LeftArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        xPosition[0]--;
                        break;

                    case ConsoleKey.RightArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        xPosition[0]++;
                        break;

                    case ConsoleKey.UpArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        yPosition[0]--;
                        break;

                    case ConsoleKey.DownArrow:
                        Console.SetCursorPosition(xPosition[0], yPosition[0]);
                        Console.Write(" ");
                        yPosition[0]++;
                        break;
                    
                }

                //Paint the Snake, make snake longer
                PaintSnake(applesEaten, xPosition, yPosition, out xPosition, out yPosition); 

                isWallHit = DidSnakeHitWall(xPosition[0], yPosition[0]);

                //Detect when snake hits boundary
                if (isWallHit)
                {
                    GameOver = false;
                    Console.SetCursorPosition(28, 30);
                    Console.WriteLine("The snake hit the wall and died!");
                }

                //Detect when apple was eaten
                isAppleEaten = DetermineIfAppleWasEaten(xPosition[0], yPosition[0], appleXDim, appleYDim);

                //Place apple on board (random)
                if (isAppleEaten)
                {
                    SetApplePositionOnScreen(random, out appleXDim, out appleYDim);
                    PaintApple(appleXDim, appleYDim);
                    //Keep track of how many apples were eaten
                    //Make snake longer
                    applesEaten++;
                    //Make snake faster
                    gameSpeed *= .925m;
                }

                if (Console.KeyAvailable) KeyInfo = Console.ReadKey().Key;
                
                //Slow game down
                System.Threading.Thread.Sleep(Convert.ToInt32(gameSpeed));
            }
            while (!GameOver);
            Console.CursorVisible = false;
        }

        private static void PaintSnake(int applesEaten, int[] xPositionIn, int[] yPositionIn, out int[] xPositionOut, out int[] yPositionOut)
        {
            //Paint the head
            Console.SetCursorPosition(xPositionIn[0], yPositionIn[0]);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine((char)214);

            //Paint the body
            for (int i = 1; i < applesEaten; i++)
            {
                Console.SetCursorPosition(xPositionIn[i], yPositionIn[i]);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("o");
            }

            //Erase last part of snake
            Console.SetCursorPosition(xPositionIn[applesEaten + 1], yPositionIn[applesEaten + 1]);
            Console.WriteLine(" ");

            //Record location of each body part
            for (int i = applesEaten; i > 0; i--)
            {
                xPositionIn[i] = xPositionIn[i - 1];
                yPositionIn[i] = yPositionIn[i - 1];
            }

            //Return the new array
            xPositionOut = xPositionIn;
            yPositionOut = yPositionIn;
        }

        private static bool DidSnakeHitWall(int xPosition, int yPosition)
        {
            if (xPosition == 1 || xPosition == 70 || yPosition == 1 || yPosition == 20)
                return true;
            return false;
        }

        private static void BuildWall()
        {
            for (int i = 1; i < 21; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(1, i);
                Console.Write("#");
                Console.SetCursorPosition(70, i);
                Console.Write("#");
            }

            for (int i = 1; i < 71; i++)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.SetCursorPosition(i, 1);
                Console.Write("#");
                Console.SetCursorPosition(i, 20);
                Console.Write("#");

            }
        }
        private static void SetApplePositionOnScreen(Random random, out int appleXDim, out int appleYDim)
        {
            appleXDim = random.Next(0 + 2, 70 - 2);
            appleYDim = random.Next(0 + 2, 20 - 2);
        }

        private static void PaintApple(int appleXDim, int appleYDim)
        {
            Console.SetCursorPosition(appleXDim, appleYDim);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write((char)64);
        }

        private static bool DetermineIfAppleWasEaten(int xPosition, int yPosition, int appleXDim, int appleYDim)
        {
            if (xPosition == appleXDim && yPosition == appleYDim)
                return true;
                return false;
        }
    }
}
