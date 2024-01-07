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
    /// This is a Unit test for variable operation class which is used to perform arithmetic opreations with the variables.
    /// </summary>  
    [TestClass()]
    public class variables_operationTests
    {
        /// <summary>
        /// In this method variable_operation class is called and the Graphic object is passed null to create an exception.
        /// </summary>
        [TestMethod()]
        [ExpectedException(typeof(ArgumentNullException), "The Exception not found")]
        public void variables_operationTest()
        {
            variables_operation vo = new variables_operation(null,null);
            vo.new_value("hello");

        }
    }
}