using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class drawto
    {

        public drawto(Graphics g, Pen p, int xpos , int ypos ,int newX , int newY)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.DrawLine(p, xpos, ypos, newX , newY);
        }
        public int updateX(int newX)
        {
            int xpos = newX;
            return xpos;
        }
        public int updateY(int newY)
        {
            int ypos = newY;
            return ypos;
        }
    }
}
