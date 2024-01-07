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
    /// This is a Unit test for method calling class which is used to call method that has no parametres in it.
    /// </summary>
    [TestClass()]
    public class method_callingTests
    {

        /// <summary>
        /// In this method method_calling class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void cmdsTest()
        {
            method_calling mc = new method_calling(null,null,null,null,null);
            mc.cmds();
        }
    }
}