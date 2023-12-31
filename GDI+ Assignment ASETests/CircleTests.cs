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
    public class CircleTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            Circle c = new Circle(50);
            c.draw(null, null, 0, 0);
        }
    }
}