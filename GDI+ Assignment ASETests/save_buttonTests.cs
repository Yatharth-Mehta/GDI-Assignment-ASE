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
    /// This is a Unit test for save file button class which is used to save files.
    /// </summary>
    [TestClass()]
    public class save_buttonTests
    {
        /// <summary>
        /// In this method save button class is called and the Sender object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void save_buttonTest()
        {
            save_button sb = new save_button(null);
        }
    }
}