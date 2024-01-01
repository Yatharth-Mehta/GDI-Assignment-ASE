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

        public void draw(Graphics g, Pen p, int xpos, int ypos,int a1,int a2,int b1,int b2,int c1,int c2)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Point[] points = { new Point(a1, a2), new Point(b1, b2), new Point(c1, c2) };
            g.DrawPolygon(p, points);
        }

        public void drawfill(Graphics g, Brush brush, int xpos, int ypos, int a1, int a2, int b1, int b2, int c1, int c2)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Point[] points = { new Point(a1, a2), new Point(b1, b2), new Point(c1, c2) };
            g.FillPolygon(brush, points);
        }
    }
}
