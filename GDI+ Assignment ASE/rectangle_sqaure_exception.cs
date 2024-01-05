using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class rectangle_sqaure_exception : Exception
    {
        public rectangle_sqaure_exception(Graphics g,int ypos)
        {
            Font f = new Font("Arial", 14);
            g.DrawString("Give proper parameters to Rectangle !", f, Brushes.Red, new Point(0, ypos));
        }
    }
}
