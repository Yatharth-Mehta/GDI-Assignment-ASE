using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDI__Assignment_ASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE.Tests
{
    [TestClass()]
    public class Invalid_command_in_multilineTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void Invalid_command_in_multilineTest()
        {
            Invalid_command_in_multiline icim = new Invalid_command_in_multiline(null, 0);
        }
    }
}