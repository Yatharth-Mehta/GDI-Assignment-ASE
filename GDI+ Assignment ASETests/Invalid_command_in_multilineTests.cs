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
    /// This is a unit test for Invalid_command_in_multiline exception class. 
    /// </summary>
    [TestClass()]
    public class Invalid_command_in_multilineTests
    {
        /// <summary>
        /// This passes null for Graphic object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void Invalid_command_in_multilineTest()
        {
            Invalid_command_in_multiline icim = new Invalid_command_in_multiline(null, 0);
        }
    }
}