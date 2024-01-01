using GDI__Assignment_ASE.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This is Circle class that will draw a circle with the radius given by the user.
    /// </summary>
    public class Circle
    {
        private int radius;
        /// <summary>
        /// A constructor is made that will take the radius entered and will assign it to the local variable which is used to 
        /// draw a circle.
        /// </summary>
        /// <param name="radius">The radius variable essential to draw the circle</param>
        public Circle(int radius)
        {
            this.radius = radius;
        }
        /// <summary>
        /// This method will draw the non-filled cirle.
        /// </summary>
        /// <param name="g">Graphic variable to draw a circle</param>
        /// <param name="p">Pen to draw a circle</param>
        /// <param name="xpos">x-position on the canvas where the circle is to be drawn</param>
        /// <param name="ypos">y-position on the canvas where the circle is to be drawn</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public void draw(Graphics g, Pen p,int xpos ,int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.DrawEllipse(p, xpos,ypos, radius, radius);
        }
        /// <summary>
        /// This method will draw the a filled cirle.
        /// </summary>
        /// <param name="g">Graphic variable to draw a circle</param>
        /// <param name="brush">Pen to draw a circle</param>
        /// <param name="xpos">x-position on the canvas where the circle is to be drawn</param>
        /// <param name="ypos">y-position on the canvas where the circle is to be drawn</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public void drawfill(Graphics g, Brush brush, int xpos, int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.FillEllipse(brush, xpos, ypos, radius,radius);
        }


    }
}
