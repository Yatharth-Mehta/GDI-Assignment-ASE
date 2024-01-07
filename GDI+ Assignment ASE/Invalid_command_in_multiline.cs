using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This is an custom exception class for any Invalid command in multiline.
    /// </summary>
    public class Invalid_command_in_multiline : Exception
    {
        /// <summary>
        /// This constructor will throw an exception by drawing an error string message on the canvas.
        /// </summary>
        /// <param name="g">Graphic element for drawing string on canvas</param>
        /// <param name="line">Gives the line number where the exception occurs</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public Invalid_command_in_multiline(Graphics g , int line)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Font f = new Font("Arial", 14);
            g.DrawString("Enter a valid command at line " + (line+1) + " !", f, Brushes.Red, new Point(50, 50));
        }
    }
}
