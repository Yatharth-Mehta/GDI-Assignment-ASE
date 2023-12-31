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
    public class while_loopTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void while_loopTest()
        {
            while_loop wl = new while_loop(null);
            wl.validation();

        }
    }
}