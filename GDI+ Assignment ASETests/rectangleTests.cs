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
    /// This is a Unit test for rectangle class which is used to draw rectangle when user
    /// passes valid paarametres.
    /// </summary>
    [TestClass()]
    public class rectangleTests
    {
        /// <summary>
        /// In this method rectangle class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            rectangle r = new rectangle(50,90);
            r.draw(null, null, 0, 0);
        }
    }
}