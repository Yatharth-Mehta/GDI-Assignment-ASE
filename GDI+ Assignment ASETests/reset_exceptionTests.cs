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
    public class reset_exceptionTests
    {
        [TestMethod()]
        public void reset_exceptionTest()
        {
            reset_exception re = new reset_exception(null,0); 
        }
    }
}