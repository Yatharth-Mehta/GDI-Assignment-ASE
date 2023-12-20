using GDI__Assignment_ASE.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class Circle
    {
        private int radius;

        public Circle(int radius)
        {
            this.radius = radius;
        }

        public void draw(Graphics g, Pen p,int xpos ,int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.DrawEllipse(p, xpos,ypos, radius, radius);
        }
        public void drawfill(Graphics g, Brush brush, int xpos, int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.FillEllipse(brush, xpos, ypos, radius,radius);
        }


    }
}
