using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class while_iteration
    {
        Graphics g;
        String fillvalue;
        String command;
        public while_iteration(String command,Graphics g,String fillvalue)
        {
            this.g = g;
            this.fillvalue = fillvalue;
            this.command = command;
        }
        public void iterate()
        {
            String code = command + "\n" + "Hello";
            Font f = new Font("Arial", 14);
            g.DrawString(code, f, Brushes.Red, new Point(50, 50));
        }
    }
}
