﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class Invalid_command_in_multiline : Exception
    {
        public Invalid_command_in_multiline(Graphics g , int line)
        {
            Font f = new Font("Arial", 14);
            g.DrawString("Enter a valid command at line " + (line+1) + " !", f, Brushes.Red, new Point(50, 50));
        }
    }
}
