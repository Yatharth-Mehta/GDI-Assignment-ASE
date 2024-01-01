using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This is Rectangle class that will draw a rectangle with the height and width given by the user.
    /// </summary>
    public class rectangle
    {
        private int height;
        private int width;
        /// <summary>
        ///  A constructor is made that will take the height and width entered and will assign it to the local variable which is used to 
        /// draw a rectangle.
        /// </summary>
        /// <param name="height">The height variable which will store the value of height of the rectangle</param>
        /// <param name="width">The width variable which will store the value of width of the rectangle</param>
        public rectangle(int height , int width)
        {
            this.height = height;
            this.width = width;
        }
        /// <summary>
        /// This method will draw the non-filled rectangle.
        /// </summary>
        /// <param name="g">Graphic variable to draw a rectangle</param>
        /// <param name="p">Pen to draw a rectangle</param>
        /// <param name="xpos">x-position on the canvas where the recctangle is to be drawn</param>
        /// <param name="ypos">y-position on the canvas where the rectangle is to be drawn</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public void draw(Graphics g, Pen p , int xpos, int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.DrawRectangle(p, xpos, ypos, height, width);
        }
        /// <summary>
        /// This method will draw the filled rectangle.
        /// </summary>
        /// <param name="g">Graphic variable to draw a rectangle</param>
        /// <param name="brush">Brush to draw a rectangle</param>
        /// <param name="xpos">x-position on the canvas where the recctangle is to be drawn</param>
        /// <param name="ypos">y-position on the canvas where the rectangle is to be drawn</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public void drawfill(Graphics g, Brush brush, int xpos, int ypos)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            g.FillRectangle(brush, xpos, ypos, height, width);
        }


    }
}
