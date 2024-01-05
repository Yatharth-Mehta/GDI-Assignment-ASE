using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This class is used for iteration of the while loop.
    /// </summary>
    public class while_iteration
    {
        Graphics g;
        String fillvalue;
        String command;
        /// <summary>
        /// This constructor will take Graphics element for exception purposes and the condition in 
        /// string value to check and the fill value for the shapes.
        /// </summary>
        /// <param name="command">The command passes in the while loop</param>
        /// <param name="g">The graphic object</param>
        /// <param name="fillvalue">Fill value to decide whether the object is to made with fill or without filled</param>
        /// <exception cref="ArgumentNullException"></exception>
        public while_iteration(String command,Graphics g,String fillvalue)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            this.g = g;
            this.fillvalue = fillvalue;
            this.command = command;
        }
        /// <summary>
        /// 
        /// </summary>
        public void iterate()
        {
            String code = command + "\n" + "Hello";
            Font f = new Font("Arial", 14);
            g.DrawString(code, f, Brushes.Red, new Point(50, 50));
        }
    }
}
