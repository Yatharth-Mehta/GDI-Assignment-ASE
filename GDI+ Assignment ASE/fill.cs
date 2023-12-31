using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class fill
    {
        public fill(Graphics g)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
        }
        public String fillvalue = "off";
    }
}
