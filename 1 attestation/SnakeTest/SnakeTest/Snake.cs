using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace SnakeTest
{
    public class Snake
    {
        public List<Point> body;
        public string sign;
        public ConsoleColor color;
        public int score = 1;

        public Snake()
        {
            sign = "*";
            body = new List<Point>();
            color = ConsoleColor.Yellow;
        }

        public void Move (int dx, int dy)
        {
            for (int i = body.Count; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }

            body[0].x += dx;
            body[0].y += dy;

            if (body[0].x < 0)
                body[0].x = Console.WindowWidth - 1;
            if (body[0].x > Console.WindowWidth)
                body[0].x = 0;

            if (body[0].y < 0)
                body[0].y = 20;
            if (body[0].y > 20)
                body[0].y = 0;
        }

        public Draw()
        {
            DrawScore();
            Console.ForegroundColor = color;
            for (int i = 0; i < body.Count; i++)
            {
                if (i == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }

                else
                    Console.ForegroundColor = color;
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(sign);
            }
        }

        public DrawScore()
        {
            Console.SetCursorPosition(35, 25);
            Console.Write("Score =  " + (score - 1) + "     ");

            Console.SetCursorPosition(35, 27);
            Console.Write("Speed = " + (11 - (Program.speed / 20)) + "   ");
        }

        public void Clear()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            for (int i = 0; i < body.Count; i++)
            {
                Console.SetCursorPosition(body[i].x, body[i].y);
                Console.Write(' ');
            }
        }

        public bool CollisionWithWall(Wall w)
        {
            foreach(Point p in w.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;               
            }
            return false;
        }

        public bool Collision()
        {
            for (int i = 1; i < body.Count; i++)
            {
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            }
            return false;
        }

        public bool Eat(Food f)
        {
            if (body[0].x == f.x && body[0].y == f.y)
            {
                return true;
            }
            return false;
        }

        public void Save()
        {
            XmlSerializer xs = new XmlSerializer(typeof(Snake));
            FileStream fs = new FileStream("snake.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            xs.Serialize(fs, this);
            fs.Close();
        }

        public void Load()
        {
            Snake res = null;
            XmlSerializer xs = new XmlSerializer(typeof(Snake));
            FileStream fs = new FileStream("snake.xml", FileMode.Open, FileAccess.Read);
            res = xs.Deserialize(fs) as Snake;
            fs.Close();
            return res;
        }
    }
}
