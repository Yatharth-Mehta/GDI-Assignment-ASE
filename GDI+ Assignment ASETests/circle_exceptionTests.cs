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
    /// This is a unit test for circle_exception class. 
    /// </summary>
    [TestClass()]
    public class circle_exceptionTests
    {
        /// <summary>
        /// This passes null for Graphic object which will throw an exception.
        /// </summary>
        [TestMethod()]
        
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]

        public void circle_exceptionTest()
        {
            circle_exception ce = new circle_exception(null, 0);
        }
    }
}