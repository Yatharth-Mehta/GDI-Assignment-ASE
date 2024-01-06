﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class triangle_exception : Exception
    {
        public triangle_exception(Graphics g,int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Font f = new Font("Arial", 14);
            g.DrawString("Give valid command of Triangle!", f, Brushes.Red, new Point(0, ypos));
        }
    }
}
