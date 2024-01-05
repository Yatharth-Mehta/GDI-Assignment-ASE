using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class clear_exception : Exception
    {
           public clear_exception(Graphics g,int ypos)
            {
                Font f = new Font("Arial", 14);
                g.DrawString("Give valid command of Clear!", f, Brushes.Red, new Point(0, ypos));
            }
    }
}
