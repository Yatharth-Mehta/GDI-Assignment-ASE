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
    /// This is a Unit test for open button class which is used to open files.
    /// </summary>
    [TestClass()]
    public class open_buttonTests
    {

        /// <summary>
        /// In this method open button class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void openTest()
        {
            open_button op = new open_button();
            op.open(null);
        }
    }
}