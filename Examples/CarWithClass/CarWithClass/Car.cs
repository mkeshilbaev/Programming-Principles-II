using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CarWithClass
{
    class Car
    {
        public GraphicsPath gp = new GraphicsPath();
        public int dir = 0;
        public int x, y;

        public Car(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw(Graphics g)
        {
            gp = new GraphicsPath();
            int w = 80;
            int h = 50;
            gp.AddRectangle(new Rectangle(x, y, w, h));
            gp.AddEllipse(new Rectangle(x + 60, y + 30, w - 40, h -20));
            gp.AddEllipse(new Rectangle(x - 30, y + 30, w - 40, h - 20));


            g.DrawPath(new Pen(Color.Red, 2), gp);
        }
    }

}
