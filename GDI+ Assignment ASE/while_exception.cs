using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class while_exception : Exception
    {
        public while_exception(Graphics g, int ypos)
        {
            Font f = new Font("Arial", 14);
            g.DrawString("Invalid 'while' command", f, Brushes.Red, new Point(0, ypos));
        }
    }
}
