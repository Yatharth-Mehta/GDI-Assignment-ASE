using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Assignment_ASE
{
    public class reset 
    {
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

        public String do_reset()
        {
            return " ";
        }
    }
}
