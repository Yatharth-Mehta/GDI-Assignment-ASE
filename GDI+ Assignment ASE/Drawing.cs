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

        public void draw(Graphics g, String cmd)
        {
            Pen pen = new Pen(Color.Red, 2);
            String command = cmd;
            command = command.ToLower();

            List<string> commandlist = new List<string>();
            commandlist.Add("circle");
            commandlist.Add("rectangle");
            commandlist.Add("triangle");
            commandlist.Add("square");
            commandlist.Add("moveto");
            commandlist.Add("drawto");
            commandlist.Add("clear");
            commandlist.Add("reset");
            commandlist.Add("pen");
            commandlist.Add("fill");



            if (commandlist.Contains(command))
            {
                switch(command)
                {
                    case "circle":
                        Circle c = new Circle(50);
                        c.draw(g, pen);
                        break;

                    case "rectangle" :
                        rectangle rect = new rectangle(50, 50);
                        rect.draw(g, pen);
                        break;
                    case "square":
                        rectangle sq = new rectangle(50, 50);
                        sq.draw(g, pen);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                errors er = new errors(g,pen);
            }

        }
    }
}
