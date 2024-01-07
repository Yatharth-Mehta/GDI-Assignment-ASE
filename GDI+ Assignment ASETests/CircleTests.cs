using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDI__Assignment_ASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE.Tests
{
    /// <summary>
    /// This is a Unit test for circle class which is used to draw a circle when user
    /// passes a valid circle command.
    /// </summary>
    [TestClass()]
    public class CircleTests
    {
        /// <summary>
        /// In this method the circle class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            Circle c = new Circle(50);
            c.draw(null, null, 0, 0);
        }
    }
}