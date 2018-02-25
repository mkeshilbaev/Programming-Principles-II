﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
namespace SNAKEEE
{
   // [Serializable]
    class Food
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
            x = new Random().Next(1, Console.WindowWidth - 1);
            y = new Random().Next(5, Console.WindowHeight - 1);
        }

        public bool Foodonwall(Wall w)
        {
            foreach (Point p in w.body)
            {
                if (p.x == x && p.y == y)
                    return false;
            }
            return true;
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
            Console.Write("@");
        }
    }
}