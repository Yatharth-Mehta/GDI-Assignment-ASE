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
    /// This is a Unit test for while_loop class which is used when while loop is created.
    /// </summary>
    [TestClass()]
    public class while_loopTests
    {
        /// <summary>
        /// In this method while_loop class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void while_loopTest()
        {
            while_loop wl = new while_loop(null);
            wl.validation();

        }
    }
}