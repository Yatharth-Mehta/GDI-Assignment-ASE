using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class rectangle
    {
        private int height;
        private int width;

        public rectangle(int height , int width)
        {
            this.height = height;
            this.width = width;
        }

        public void draw(Graphics g, Pen p , int xpos, int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.DrawRectangle(p, xpos, ypos, height, width);
        }

        public void drawfill(Graphics g, Brush brush, int xpos, int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.FillRectangle(brush, xpos, ypos, height, width);
        }


    }
}
