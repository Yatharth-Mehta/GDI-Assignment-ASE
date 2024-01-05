﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class if_exception : Exception
    {
        public if_exception(Graphics g) 
        {
            Font f = new Font("Arial", 14);
            g.DrawString("Invalid 'if' command", f, Brushes.Red, new Point(50, 50));
        }
    }
}