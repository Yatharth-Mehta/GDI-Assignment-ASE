using Microsoft.VisualStudio.TestTools.UnitTesting;
using GDI__Assignment_ASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE.Tests
{
    /// <summary>
    /// This is a Unit test for if condition calling class which is used to check the if condition that user
    /// passes.
    /// </summary>
    [TestClass()]
    public class if_condition_callingTests
    {
        /// <summary>
        /// In this method the if_condition_calling class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void cmdsTest()
        {
            if_condition_calling ifcc = new if_condition_calling(null,null,null,null,null);
            ifcc.cmds();
        }
    }
}