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
    /// This is a Unit test for reset class which is used to reset the whole form when user
    /// passes valid command.
    /// </summary>
    [TestClass()]
    public class resetTests
    {
        /// <summary>
        /// In this method reset class is called and the String commandline is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void resetTest()
        {
            reset r = new reset("hello", null);
            r.do_reset();
        }
        /// <summary>
        /// In this method reset class is called and the String multiline is passed null to create an exception.
        /// </summary>
        public void resetTests_2()
        {
            reset r = new reset(null, "hello");
            r.do_reset();
        }
    }
}