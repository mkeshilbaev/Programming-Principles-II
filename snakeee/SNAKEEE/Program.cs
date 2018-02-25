using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SNAKEEE
{
    class Program
    {       
        static Snake snake = new Snake();
        static Wall wall = new Wall(1);
        static Food food = new Food();
        static int direction = 1;   // 1 - left, 2 - right, 3 - up, 4 - down
        static bool gameOver = false;
        static int speed = 200;

        static void PlayGame()
        {
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

                Console.Clear();
                snake.Draw();
                wall.Draw();

                if (snake.score % 10 == 0)
                {
                    speed = Math.Max(speed - 15, 100);
                }               
                Thread.Sleep(speed);
            }
        }

            static void Main(string[] args)
        {
            Console.SetWindowSize(80, 30);
            Console.CursorVisible = false;
            int level = 1;
            int score = 0;
          /*int points = F7();
            Wall wall = new Wall(level);
            Snake snake = new Snake();
            Food food = new Food();
           */
            Console.WriteLine("Press 'R' to restart the game...");
            //Console.WriteLine("Press 'C' to continue the last game...");
            // ConsoleKeyInfo key1 = Console.ReadKey();

            /*if (key1.Key == ConsoleKey.C)
            {
                snake = F2();
                wall = F4();
                points = F7();
                food = F6();
                score = snake.score;
            }
            */

           /* Console.Clear();
            wall.WallDraw();
            snake.Draw();
            food.ShowFood();
            */
            Console.CursorVisible = false;
            Thread thread = new Thread(PlayGame);
            thread.Start();

            while (!gameOver)
            {
                /*Console.SetCursorPosition(0, 0);
                Console.WriteLine("High score : " + " " + points + "   Score: " + score + " " + "Level" + " " + level);
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("If you want to safe current score, enter [5]");
                
                Console.SetCursorPosition(0, 2);
                Console.WriteLine("If you want to quit, enter [Escape] ");
                */

                ConsoleKeyInfo keyInfo = Console.ReadKey();
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = 1;

                if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = 2;

                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = 3;

                if (keyInfo.Key == ConsoleKey.DownArrow)
                    direction = 4;

                if (keyInfo.Key == ConsoleKey.Escape)
                    gameOver = true;

                if (keyInfo.Key == ConsoleKey.R) // new game
                {
                    Console.Clear();

                    snake = new Snake();
                    level = 1;
                    score = 0;
                    wall = new Wall(level);
                }
                /*
                if (info.Key == ConsoleKey.NumPad5)
                {
                    snake.score = score;
                    F1(snake);
                    F3(wall);
                    F5(food);
                    F8(points);
                }
                */             
                
                if (snake.CollisionWithWall(wall) || snake.Collision())
                {
                    Console.Clear();
                    Console.SetCursorPosition(7, 7);
                    StreamReader sr = new StreamReader(@"C:\Users\mkesh\Desktop\PP2\snakeee\SNAKEEE\gameover.txt");
                    string s = sr.ReadToEnd();
                    Console.WriteLine(s);
                //    Console.WriteLine("High Score : " + points + "Your Score is " + score);

                    Console.ReadKey();
                    snake = new Snake();
                    level = 1;
                    wall = new Wall(level);
                    score = 0;
                }

                 while(!food.Foodonwall(wall) || !food.Foodonsnake(snake))
                 {
                     food.SetRandomPos();
                     Console.SetCursorPosition(food.x, food.y);
                     Console.Write("@");
                 }                

                if (snake.Eat(food))
                {
                    snake.AddBody();
                    food.SetRandomPos();
                    score += 10;
                   // points = Math.Max(points, score);
                    Console.SetCursorPosition(food.x, food.y);
                    Console.Write("@");
                }

                if (score == level * 5)
                {
                    level++;
                    wall = new Wall(level);
                }
                Console.Clear();
                snake.Draw();
                food.Draw();
                wall.Draw();
            }
        }
    }
}

/* static void F1(Snake snake)
         {
             FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
             BinaryFormatter bf = new BinaryFormatter();
             bf.Serialize(fs, snake);
             fs.Close();
         }

         static Snake F2()
         {
             FileStream fs = new FileStream("data.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
             BinaryFormatter bf = new BinaryFormatter();
             Snake s = bf.Deserialize(fs) as Snake;
             fs.Close();
             return s;
         }

         static void F3(Wall wall)
         {
             FileStream fs = new FileStream("data1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
             BinaryFormatter bf = new BinaryFormatter();
             bf.Serialize(fs, wall);
             fs.Close();
         }

         static Wall F4()
         {
             FileStream fs = new FileStream("data1.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
             BinaryFormatter bf = new BinaryFormatter();
             Wall w = bf.Deserialize(fs) as Wall;
             fs.Close();
             return w;
         }

         static void F5(Food food)
         {
             FileStream fs = new FileStream("data2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
             BinaryFormatter bf = new BinaryFormatter();
             bf.Serialize(fs, food);
             fs.Close();
         }

         static Food F6()
         {
             FileStream fs = new FileStream("data2.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
             BinaryFormatter bf = new BinaryFormatter();
             Food f = bf.Deserialize(fs) as Food;
             fs.Close();
             return f;
         }

         static int F7()
         {
             StreamReader sr = new StreamReader(@"C:\Users\mkesh\Desktop\PP2\snakeee\SNAKEEE\points.txt");
             string s = sr.ReadLine();
             sr.Close();
             return int.Parse(s);
         }

         static void F8(int a)
         {
             StreamWriter sw = new StreamWriter(@"C:\Users\mkesh\Desktop\PP2\snakeee\SNAKEEE\points.txt");
             sw.WriteLine(a);
             sw.Close();

         }
         */
