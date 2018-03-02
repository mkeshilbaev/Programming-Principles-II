using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SNAKEEE
{

    public class Food
    {
        public int x, y;
        public Food()
        {
            SetRandomPos();
        }

        public Food(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void SetRandomPos()
        {
            x = new Random().Next(1, 78);
            y = new Random().Next(1, 20);
        }

        public bool Foodonwall(Wall w)
        {
            foreach (Point p in w.body)
            {
                if (p.x == this.x && p.y == this.y)
                {
                    return true;
                }
            }
            return false;
        }

        public bool Foodonsnake(Snake s)
        {
            foreach (Point p in s.body)
            {
                if (p.x == x && p.y == y)
                    return false;
            }
            return true;
        }

        public void Draw()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("@");
        }
    }
}