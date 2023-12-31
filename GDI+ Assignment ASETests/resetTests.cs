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
    public class resetTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void resetTest()
        {
            reset r = new reset("hello", null);
            r.do_reset();
        }
        public void resetTests_2()
        {
            reset r = new reset(null, "hello");
            r.do_reset();
        }
    }
}