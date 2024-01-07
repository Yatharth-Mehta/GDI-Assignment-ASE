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
    /// This is a Unit test for multiline class which is used to handle multiline text box commands.
    /// </summary>
    [TestClass()]
    public class multilineTests
    {
        /// <summary>
        /// In this method multiline class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void variablesTest()
        {
            multiline ml = new multiline(null, null,null);
            ml.multiline_main();
        }
    }
}