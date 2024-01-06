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
    /// This is a unit test for method_exception class. 
    /// </summary>
    [TestClass()]
    public class method_exceptionTests
    {
        /// <summary>
        /// This passes null for Graphic object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]

        public void method_exceptionTest()
        {
            method_exception me = new method_exception(null, 0);
        }
    }
}