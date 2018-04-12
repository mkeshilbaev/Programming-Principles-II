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

namespace BattleShip
{
    class Field
    {
        public GraphicsPath gp;
        Pen pen;

        public Square(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
