using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid2
{
    public class Game
    {
        Point packman;
        List<Point> wall;
        List<Point> food;
        int cnt;

        public Game()
        {
            packman = new Point();
            wall = new List<Point>();
            food = new List<Point>();
            cnt = 0;
        }

        public void Start()
        {
            ReadAll();
            bool quit = false;

            while (!quit)
            {
                Draw();
                ConsoleKeyInfo KeyInfo = Console.ReadKey(true);

                if(KeyInfo.Key == ConsoleKey.UpArrow)
                {
                    Point p = new Point(packman.X, packman.Y - 1);
                    if(!Equal(p, wall))
                    {
                        packman.Y--;
                    }
                }

                if (KeyInfo.Key == ConsoleKey.DownArrow)
                {
                    Point p = new Point(packman.X, packman.Y + 1);
                    if (!Equal(p, wall))
                    {
                        packman.Y++;
                    }
                }

                if (KeyInfo.Key == ConsoleKey.LeftArrow)
                {
                    Point p = new Point(packman.X - 1, packman.Y);
                    if (!Equal(p, wall))
                    {
                        packman.X--;
                    }
                }

                if (KeyInfo.Key == ConsoleKey.RightArrow)
                {
                    Point p = new Point(packman.X + 1, packman.Y);
                    if (!Equal(p, wall))
                    {
                        packman.X++;
                    }
                }

                if (KeyInfo.Key == ConsoleKey.Escape)
                {
                    quit = true;
                }
            }
            Console.Clear();
        }

        void Draw()
        {
            Console.Clear();
            foreach(Point p in wall)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write('*');
            }

            foreach (Point p in food)
            {
                Console.SetCursorPosition(p.X, p.Y);
                Console.Write('f');
            }

            Console.SetCursorPosition(packman.X, packman.Y);
            Console.Write('0');

        }

        bool Equal(Point point, List<Point> body)
        {
            foreach(Point p in body)
            {
                if(p.X == point.X && p.Y == point.Y)
                {
                    return true;
                }
            }
            return false;
        }

        void ReadAll()
        {
           
            StreamReader sr = new StreamReader("input.txt");
            FileStream fs = new FileStream("input.txt", FileMode.Open, FileAccess.Read);
            string s;
            int y = 0;

            while ((s = sr.ReadLine()) != null)
            {
                for (int x = 0; x < s.Length; x++)
                {
                    if (s[x] == '*')
                    {
                        wall.Add(new Point(x, y));
                    }

                    if(s[x] == '0')
                    {
                        packman = new Point(x, y);
                    }

                    if(s[x] == 'f')
                    {
                        food.Add(new Point(x, y));
                    }
                }
                y++;
            }
        }
    }
}