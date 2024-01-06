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
    public class rectangle_sqaure_exceptionTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]

        public void rectangle_sqaure_exceptionTest()
        {
            rectangle_sqaure_exception rse = new rectangle_sqaure_exception(null, 0);
        }
    }
}