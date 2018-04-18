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

namespace Tank
{
    class Tank
    {
        public GraphicsPath gp;
        public int x, y;
        public int dir = 0;

        public Tank(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw(Graphics g)
        {
            gp = new GraphicsPath();
            int w = 50;
            int h = 70;
            gp.AddRectangle(new Rectangle(x, y, w, h));
            gp.AddEllipse(new Rectangle(x+8, y+8, w-15, h-20));
            //gp.AddLine();
            SolidBrush brush = new SolidBrush(Color.Green);
            g.FillRectangle(brush, x, y, w, h);
            g.FillEllipse(new SolidBrush(Color.Yellow), x + 8, y + 8, w - 15, h - 20);

            if (dir == 1)
                gp.AddLine(x + w / 2, y + h / 2, x + w / 2, y + h / 2);
            if (dir == 2)
                gp.AddLine(x + w / 2, y + h / 2, x + w / 2, y + h / 2);
            if (dir == 3)
                gp.AddLine(x + w / 2, y + h / 2, x + w / 2, y + h / 2);
            if (dir == 4)
                gp.AddLine(x + w / 2, y + h / 2, x + w / 2, y + h / 2);

            g.DrawPath(new Pen(Color.Blue, 2), gp);
        }
    }
}
