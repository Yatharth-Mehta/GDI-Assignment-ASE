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
    /// This is a Unit test for syntax checking class which is used to check the syntax of the commands passed
    /// by the user
    /// </summary>
    [TestClass()]
    public class syntax_checkingTests
    {
        /// <summary>
        /// This method will call the syntax checking class and will throw null to it's graphics element which will throw an error
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]

        public void checkTest()
        {
            syntax_checking sc = new syntax_checking();
            sc.check(null,null,0);
        }
    }
}