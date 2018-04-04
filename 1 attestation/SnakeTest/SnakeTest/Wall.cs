using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace SnakeTest
{
    public class Wall
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;

        public void ReadLevel(int level)
        {
            string fname = @"C:\Users\mkesh\Desktop\PP2\snakeee\SNAKEEE\level" + level + ".txt";
            FileStream fs = new FileStream(fname, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            Stream sr = new StreamReader(fs);
            string line;
            int y = 0;

            while((line == sr.ReadLine()) != null)
            {
                for (int x = 0; x < line.Length; x++)
                {
                    if (line[x] == '#')
                    {
                        this.body.Add(new Point(x + 1, y));
                    }
                }
                y++;
            }
            sr.Close();
            fs.Close();
        }

        public Wall(int level)
        {
            body = new List<Point>;
            sign = "#";
            color = ConsoleColor.White;
            ReadLevel(level);
        }

        public void Draw()
        {
            foreach(Point p in body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.ForegroundColor = color;
                Console.Write(sign);
            }
        }
    }
}
