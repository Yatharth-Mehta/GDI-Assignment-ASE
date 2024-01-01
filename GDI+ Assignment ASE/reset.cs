using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This class will reset the whole form by clearing the multiline and commandline box , drawing canvas etc.
    /// </summary>
    public class reset
    {
        /// <summary>
        /// This constructor will access the commandline and multiline to reset those.
        /// </summary>
        /// <param name="commandline">The string in commandline</param>
        /// <param name="multiline">The string in multiline</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the commandline or multiline variable is null</exception>
        public reset(String commandline , String multiline)
        {
            if (commandline is null)
            {
                throw new ArgumentNullException(nameof(commandline));
            }
            if (multiline is null)
            {
                throw new ArgumentNullException(nameof(multiline));
            }
            commandline = "";
            multiline = "";
        }

        /// <summary>
        /// This will actually reset the target element when called as it returns blank space.
        /// </summary>
        /// <returns></returns>
        public String do_reset()
        {
            return " ";
        }
    }
}
