using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDI__Assignment_ASE.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE.Properties.Tests
{
    [TestClass()]
    public class DrawingTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void drawTest()
        {
            Drawing drawing = new Drawing();
            drawing.draw(null, null,null);
        }
    }
}