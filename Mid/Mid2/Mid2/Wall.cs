using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Mid2
{
    public class Wall
    {
        public List<Point> body;

        public Wall()
        {
            body = new List<Point>();
        }

        public void ReadLevel()
        {
            StreamReader sr = new StreamReader("input.txt");

            for (int i = 0; i < 100; i++)
            {
                string s = sr.ReadLine();
                for (int j = 0; j < s.Length; j++)
                    if (s[j] == '#')
                        body.Add(new Point(j, i));
            }
            sr.Close();
        }

        public void Draw()
        {
            foreach (Point point in body)
            {
                Console.SetCursorPosition(point.x, point.y);
                Console.WriteLine("*");
            }
        }
    }
}