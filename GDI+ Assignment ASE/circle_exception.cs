﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class circle_exception : Exception
    {
        public circle_exception(Graphics g)
        {
            Font f = new Font("Arial", 14);
            g.DrawString("Give proper parameters to circle !", f, Brushes.Red, new Point(50, 50));
        }
    }
}