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
    /// This is a unit test for cmdline_empty_exception class. 
    /// </summary>
    [TestClass()]
    public class cmdline_empty_exceptionTests
    {
        /// <summary>
        /// This passes null for Graphic object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]

        public void cmdline_empty_exceptionTest()
        {
            cmdline_empty_exception cmdempex = new cmdline_empty_exception(null, 0); 
        }
    }
}