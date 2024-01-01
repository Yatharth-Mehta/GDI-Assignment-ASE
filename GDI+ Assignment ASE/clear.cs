using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This is Clear class that will clear the canvas whenever called.
    /// </summary>
    public class clear
    {
        /// <summary>
        /// This draw method will clear the whole canvas and will give it the color white.
        /// </summary>
        /// <param name="g">Graphics object used to clear</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public void draw(Graphics g)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.Clear(Color.White);
        }
    }
}
