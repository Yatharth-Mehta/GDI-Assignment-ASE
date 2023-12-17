using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Assignment_ASE.Properties
{
    public class Drawing
    {
        public void draw(Graphics g,String command)
        {
            Pen pen = new Pen(Color.Red, 2);

            if (command == "circle")
            {
            Circle circle = new Circle(25);
            circle.draw(g, pen);
            }

            else if (command == "square" || command  == "rectangle")
            {
                rectangle rect = new rectangle(50,50);
                rect.draw(g, pen);
            }
        }
    }
}
