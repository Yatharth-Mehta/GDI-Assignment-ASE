using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDI__Assignment_ASE.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE.Properties.Tests
{
    /// <summary>
    /// This is a Unit test for drawing class which is used to draw whatever command user passes.
    /// </summary>
    [TestClass()]
    public class DrawingTests
    {
        ////// <summary>
        /// In this method the drawing class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            Drawing drawing = new Drawing();
            drawing.draw(null, null,null);
        }
    }
}