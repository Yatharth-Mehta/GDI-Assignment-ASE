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
            g.DrawString("Enter a valid command !",default(Font),Brushes.Red,new Point(50,50));
        }
    }
}
