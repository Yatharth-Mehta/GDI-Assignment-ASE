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
    /// This is a Unit test for while_iteration class which is used for iterating while loop.
    /// </summary>
    [TestClass()]
    public class while_iterationTests
    {
        /// <summary>
        /// In this method while_iteration class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void while_iterationTest()
        {
            while_iteration wi = new while_iteration(null, null, null);
            wi.iterate();
        }
    }
}