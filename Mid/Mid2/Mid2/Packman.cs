using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mid2
{ 
    public class Packman
    {
        public List<Point> body;
        public char wall, food;
        public int packman, dx, dy;
        public int cnt = 0;
        

        public Packman(char _wall, char _food, int _packman)
        {
            body = new List<Point>();
                wall = _wall;
                food = _food;
                packman = _packman;
        }

        public void AddBody()
        {
            body.Add(new Point(0, 0));
        }

        public void Move(int dx, int dy)
        {
            for (int i = body.Count; i > 0; i--)
            {
                body[i].x += body[i + 1].x;
                body[i].y += body[i + 1].x;
            }
            body[0].x += dx;
            body[0].y += dy;
        }

        public void Draw()
            {
            Console.Write('0');
           
            }
                
    }
}