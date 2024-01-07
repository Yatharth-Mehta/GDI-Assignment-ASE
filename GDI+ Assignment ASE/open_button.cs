using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// A class to be called when open button is clicked to check the exception.
    /// </summary>
    public class open_button
    {
        /// <summary>
        /// This class will check whether the object sender is null and will throw an exception.
        /// </summary>
        /// <param name="sender">An object passed through the form</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>

        public void open(object sender)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }
            
        }
    }
}
