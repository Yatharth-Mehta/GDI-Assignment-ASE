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
    /// This is a Unit test for if_condition class which is used to check the if condition user passes.
    /// </summary>
    [TestClass()]
    public class if_conditionTests
    {
        /// <summary>
        /// In this method the if condition class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void if_statementTest()
        {
            if_condition ifc = new if_condition(null, null);
            ifc.if_statement();
        }
    }
}