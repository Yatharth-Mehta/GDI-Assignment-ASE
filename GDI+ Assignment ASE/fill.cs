using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This the class for the fill value of the shape.This will take a graphic element for the purpose of exception.
    /// </summary>
    public class fill
    {
        /// <summary>
        /// This fill constructor takes the Graphics element and has a public String that will have the value off which 
        /// will be used in the multiline.cs as the default value.
        /// </summary>
        /// <param name="g">The Graphics variable</param>
        /// <exception cref="ArgumentNullException"></exception>
        public fill(Graphics g)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
        }
        public String fillvalue = "off";
    }
}
