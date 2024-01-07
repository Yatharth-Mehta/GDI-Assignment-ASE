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
    /// This is a Unit test for method calling with parametres class which is used to call method that has parametres in it.
    /// </summary>
    [TestClass()]
    public class method_calling_with_parametresTests
    {
        /// <summary>
        /// In this method method_calling_with_parametres class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void cmdsTest()
        {
            method_calling_with_parametres mcwp = new method_calling_with_parametres(null, null, null, null, null);
            mcwp.cmds();
        }
    }
}