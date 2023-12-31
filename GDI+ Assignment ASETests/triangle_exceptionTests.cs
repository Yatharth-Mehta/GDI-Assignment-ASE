﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDI__Assignment_ASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE.Tests
{
    /// <summary>
    /// This is a unit test for cmdline_empty_exception class. 
    /// </summary>
    [TestClass()]
    public class triangle_exceptionTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]

        public void triangle_exceptionTest()
        {
            /// <summary>
            /// This passes null for Graphic object which will throw an exception.
            /// </summary>
            triangle_exception te = new triangle_exception(null,0);
        }
    }
}