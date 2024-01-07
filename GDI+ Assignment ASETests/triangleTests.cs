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
    /// This is a Unit test for triangle class which is used to draw a triangle when user
    /// passes a valid triangle command.
    /// </summary>
    [TestClass()]
    public class triangleTests
    {
        /// <summary>
        /// In this method triangle class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            triangle tr = new triangle(null,null);
            tr.draw(null,null,0,0,0,0,0,0,0,0);

        }
    }
}