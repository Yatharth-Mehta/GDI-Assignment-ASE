using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Assignment_ASE
{
    public class open_button
    {
        public void open(object sender)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }
            
        }
    }
}
