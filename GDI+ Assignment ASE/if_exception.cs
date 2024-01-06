using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class if_exception : Exception
    {
        /// <summary>
        /// This is an custom exception class for if command.
        /// </summary>
        public if_exception(Graphics g,int ypos) 
        {
            /// <summary>
            /// This constructor will throw an exception by drawing an error string message on the canvas.
            /// </summary>
            /// <param name="g">Graphic element for drawing string on canvas</param>
            /// <param name="ypos">The position of the text on Y-axis</param>
            /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Font f = new Font("Arial", 14);
            g.DrawString("Invalid 'if' command", f, Brushes.Red, new Point(0, ypos));
        }
    }
}
