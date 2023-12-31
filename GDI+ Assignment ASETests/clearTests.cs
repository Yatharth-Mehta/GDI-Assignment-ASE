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
    public class clearTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            clear c = new clear();
            c.draw(null);
        }
    }
}