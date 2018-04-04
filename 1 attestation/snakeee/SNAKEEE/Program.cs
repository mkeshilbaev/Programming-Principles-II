using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Xml.Serialization;

namespace SNAKEEE
{
    class Program
    {       
        static Snake snake = new Snake();
        static Wall wall = new Wall(1);
        static Food food = new Food(40 ,5);
        static int direction = 1;   // 1 - left, 2 - right, 3 - up, 4 - down
        static bool gameOver = false;
        public static int speed = 150;
        static int score = 1, level = 1;

        static void PlayGame()
        {
            snake.body.Add(new Point(5, 5));
            wall.Draw();
            food.Draw();

            while (!gameOver)
            {
                if (direction == 1)
                    snake.Move(-1, 0);

                if (direction == 2)
                    snake.Move(1, 0);

                if (direction == 3)
                    snake.Move(0, -1);

                if (direction == 4)
                    snake.Move(0, 1);

                if (snake.score == 50)
                    wall = new Wall(2);

                if (snake.Eat(food))
                {
                    snake.AddBody();
                    snake.score += 10;
                    food.SetRandomPos();
                    speed = Math.Max(speed - 50, 100);
                    Console.SetCursorPosition(food.x, food.y);
                }

                while (food.Foodonwall(wall))
                {
                    food.SetRandomPos();
                }
                food.Draw();

                if (snake.score - 1 == level * 30)
                {
                    level++;
                    wall.body.Clear();
                    Console.Clear();
                    wall.ReadLevel(level);
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

                    Console.Clear();
                    snake = new Snake();
                    level = 1;
                    wall = new Wall(level);
                    score = 0;
                    wall.Draw();
                    food.Draw();
                    continue;                   
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

            while (!gameOver)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = 1;

                if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = 2;
            
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = 3;

                if (keyInfo.Key == ConsoleKey.DownArrow)
                    direction = 4;

                if (keyInfo.Key == ConsoleKey.Escape)
                {
                    gameOver = true;
                }           
                
                if(keyInfo.Key == ConsoleKey.S)
                {
                    snake.Save();
                }

                if(keyInfo.Key == ConsoleKey.L)
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

