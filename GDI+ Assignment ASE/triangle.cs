using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This is Triangle class that will draw a triangle with the co-ordinates given by the user.
    /// </summary>
    public class triangle
    {
        /// <summary>
        /// This constructor will take the graphic object and pen object so drawing can be posiibel further in the class.
        /// </summary>
        /// <param name="g">The Graphic object</param>
        /// <param name="p">The Pen object</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public triangle(Graphics g,Pen p)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
        }

        /// <summary>
        /// This method will draw a non-fillled triangle with the points of co-ordinates entered by the user
        /// </summary>
        /// <param name="g">Graphic object to draw a triangle</param>
        /// <param name="p">Pen object in order to draw a triangle</param>
        /// <param name="xpos">x-position on the canvas where the recctangle is to be drawn</param>
        /// <param name="ypos">y-position on the canvas where the rectangle is to be drawn</param>
        /// <param name="a1">The x value of first point of the triangle</param>
        /// <param name="a2">The y value of first point of the triangle</param>
        /// <param name="b1">The x value of second point of the triangle</param>
        /// <param name="b2">The y value of second point of the triangle</param>
        /// <param name="c1">The x value of third point of the triangle</param>
        /// <param name="c2">The y value of third point of the triangle</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public void draw(Graphics g, Pen p, int xpos, int ypos,int a1,int a2,int b1,int b2,int c1,int c2)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Point[] points = { new Point(a1, a2), new Point(b1, b2), new Point(c1, c2) };
            g.DrawPolygon(p, points);
        }

        /// <summary>
        /// This method will draw a fillled triangle with the points of co-ordinates entered by the user
        /// </summary>
        /// <param name="g">Graphic object to draw a triangle</param>
        /// <param name="brush">Brush object in order to draw a triangle</param>
        /// <param name="xpos">x-position on the canvas where the recctangle is to be drawn</param>
        /// <param name="ypos">y-position on the canvas where the rectangle is to be drawn</param>
        /// <param name="a1">The x value of first point of the triangle</param>
        /// <param name="a2">The y value of first point of the triangle</param>
        /// <param name="b1">The x value of second point of the triangle</param>
        /// <param name="b2">The y value of second point of the triangle</param>
        /// <param name="c1">The x value of third point of the triangle</param>
        /// <param name="c2">The y value of third point of the triangle</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public void drawfill(Graphics g, Brush brush, int xpos, int ypos, int a1, int a2, int b1, int b2, int c1, int c2)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Point[] points = { new Point(a1, a2), new Point(b1, b2), new Point(c1, c2) };
            g.FillPolygon(brush, points);
        }
    }
}
