using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class reset_exception : Exception
    {
        public reset_exception(Graphics g)
        {
            Font f = new Font("Arial", 14);
            g.DrawString("Give valid command of Reset!", f, Brushes.Red, new Point(50, 50));
        }
    }
}
