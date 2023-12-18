using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class errors
    {
        public errors(Graphics g, Pen p)
        {
            Font f = new Font("Arial", 14);
            g.DrawString("Enter a valid command !",f,Brushes.Red,new Point(50,50));
        }
    }
}
