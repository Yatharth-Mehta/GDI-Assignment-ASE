using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This is an custom exception class if the command of command_line is not valid.
    /// </summary>
    public class Not_a_valid_command_exception : Exception
    {
        /// <param name="g">Graphic element for drawing string on canvas</param>
        /// <param name="ypos">The position of the text on Y-axis</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public Not_a_valid_command_exception(Graphics g,int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Font f = new Font("Arial", 14);
            g.DrawString("Enter a valid command !", f, Brushes.Red, new Point(0, ypos));
        }
    }
}
