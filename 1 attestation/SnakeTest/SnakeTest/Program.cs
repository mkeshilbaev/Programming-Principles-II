using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Threading;

namespace SnakeTest
{
    class Program
    {
        static Snake snake = new Snake();
        static Wall wall = new Wall(1);
        static Food food = new Food(40, 5);
        static int direction = 1;
        static bool GameOver = false;
        public static int speed = 200;
        static int score = 1, level = 1;

        static void PlayGame()
        {
            snake.body.Add(new Point(5, 5));
            wall.Draw();
            food.Draw();

            while (!GameOver)
            {
                if (direction == 1)
                    snake.Move(-1, 0);

                if (direction == 2)
                    snake.Move(0, 1);

                if (direction == 3)
                    snake.Move(0, 1);

                if (direction == 4)
                    snake.Move(0, -1);

                if (snake.Eat(food))
                {
                    snake.AddBody();
                    snake.score += 10;
                    food.SetRandomPos();
                    speed = Math.Max(speed - 20, 100);
                    Console.SetCursorPosition(food.x, food.y);
                }

                while (food.FoodOnWall(wall))
                {
                    food.SetRandomPos();
                }
                food.Draw();

                if (snake.score - 1 == level * 100)
                {
                    level++;
                    wall.body.Clear();
                    Console.Clear();
                    wall.Draw();
                }

                if (snake.CollisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(7, 7);
                    StreamReader sr = new StreamReader(@"C:\Users\mkesh\Desktop\PP2\snakeee\SNAKEEE\gameover.txt");
                    string s = sr.ReadToEnd();
                    Console.WriteLine(s);
                    Console.ReadKey();


                }
                snake.Draw();
                Thread.Sleep(speed);
                snake.Clear();
            }
        }

        static void Main(string[] args)
        {
            Console.SetWindowSize(80, 30);
            Console.CursorVisible = false;

            Thread thread = new Thread(PlayGame);
            thread.Start();

            while (!GameOver)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = 1;

                if (keyInfo.Key == ConsoleKey.DownArrow)
                    direction = 2;

                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = 3;

                if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = 4;

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    GameOver = true;
                }

                if (keyInfo.Key == ConsoleKey.S)
                    snake.Save();

                if (keyInfo.Key == ConsoleKey.L)
                {
                    snake.Clear();
                    snake.body.Clear();
                    snake = Snake.Load();
                    snake.Draw();
                }
            }
        }
    }
}
