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
    /// This is a unit test Not_a_valid_command_exception class. 
    /// </summary>
    [TestClass()]
    public class Not_a_valid_command_exceptionTests
    {
        /// <summary>
        /// This passes null for Graphic object which will throw an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]

        public void Not_a_valid_command_exceptionTest()
        {
            Not_a_valid_command_exception nave = new Not_a_valid_command_exception(null, 0);
        }
    }
}