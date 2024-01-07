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
    /// This is a Unit test for clear class which is used to circle the picture box when user
    /// passes a valid clear command.
    /// </summary>
    [TestClass()]
    public class clearTests
    {
        /// <summary>
        /// In this method the clear class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            clear c = new clear();
            c.draw(null);
        }
    }
}