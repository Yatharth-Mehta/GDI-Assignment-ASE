using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class triangle
    {
        public triangle(Graphics g,Pen p)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
        }

        public void draw(Graphics g, Pen p, int xpos, int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Point[] points = { new Point(10, 100), new Point(120, 10), new Point(200, 100) };
            g.DrawPolygon(p, points);
        }

        public void drawfill(Graphics g, Brush brush, int xpos, int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Point[] points = { new Point(10, 100), new Point(120, 10), new Point(200, 100) };
            g.FillPolygon(brush, points);
        }
    }
}
