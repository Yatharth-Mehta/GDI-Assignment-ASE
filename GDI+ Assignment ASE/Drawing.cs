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

            String[] split_command = command.Split(' ');
            
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

            int xpos = 0;
            int ypos = 0;

            if (commandlist.Contains(split_command[0]))
            {
                switch(split_command[0])
                {
                    case "circle":                               
                            Circle c = new Circle(int.Parse(split_command[1]));
                            c.draw(g, pen, xpos, ypos);
                        break;

                    case "rectangle" :
                        rectangle rect = new rectangle(int.Parse(split_command[1]), int.Parse(split_command[2]));
                        rect.draw(g, pen, xpos, ypos);
                        break;

                    case "square":
                        rectangle sq = new rectangle(int.Parse(split_command[1]), int.Parse(split_command[2]));
                        sq.draw(g, pen, xpos, ypos);
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
