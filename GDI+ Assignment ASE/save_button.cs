using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class save_button
    {
        public save_button(object sender)
        {
            if (sender is null)
            {
                throw new ArgumentNullException(nameof(sender));
            }
        }
    }
}
