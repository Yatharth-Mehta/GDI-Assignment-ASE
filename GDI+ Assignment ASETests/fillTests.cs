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
    /// This is a Unit test for fill class which is used to decide the value of fill which will decide whether
    /// to draw a shape filled or non-filled.
    /// </summary>
    [TestClass()]
    public class fillTests
    {
        /// <summary>
        /// In this method the fill class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void fillTest()
        {
            fill fl = new fill(null);
        }
    }
}