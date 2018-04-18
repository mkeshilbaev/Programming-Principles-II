﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Pricel
{
    class Shape
    {
        float x, y, w, h;
        Pen pen;

        public Shape(float x, float y, float w, float h, Color color)
        {
            this.x = x;
            this.y = y;
            this.w = w;
            this.h = h;
            Pen pen = new Pen(color, 5);
        }

        public void Draw(Graphics g)
        {
            PointF p1 = new PointF(x + w / 2, y);
            PointF p2 = new PointF(x + w / 2, y + h);
            PointF p3 = new PointF(x, y + h / 2);
            PointF p4 = new PointF(x + w, y + h / 2);
            g.DrawLine(pen, p1, p2);
            g.DrawLine(pen, p3, p4);

            float r1 = w / 4;
            float xr1 = w / 4 + x;
            float yr1 = h / 4 + y;
            g.DrawEllipse(pen, xr1, yr1, w / 2, h / 2);

            g.DrawEllipse(pen, x, y, w, h);
        }
    }
}
