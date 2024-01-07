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
    /// This is a Unit test for while calling class which is used when using while loop to perform action .
    /// </summary>
    [TestClass()]
    public class while_callingTests
    {
        /// <summary>
        /// In this method while_calling class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void while_callingTest()
        {
            while_calling wc = new while_calling(null,null,null,null,null);
            wc.cmds();
        }
    }
}