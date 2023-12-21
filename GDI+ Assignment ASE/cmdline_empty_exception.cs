using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class cmdline_empty_exception : Exception
    {
        public cmdline_empty_exception(Graphics g)
        {
            Font f = new Font("Arial", 14);
            g.DrawString("The Command Line is Empty !", f, Brushes.Red, new Point(50, 50));
        }
    }
}
