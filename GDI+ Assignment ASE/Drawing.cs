using GDI__Assignment_ASE;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GDI__Assignment_ASE.Properties
{
    /// <summary>
    /// This is Drawing class that will draw the commands given to it with valid parameters.
    /// This class will not draw anything by itself.It will call the concerning drawing class which will then draw the shape
    /// </summary>
    public class Drawing
     {
        private int xpos = 0;
        private int ypos = 0;
        /// <summary>
        /// This Draw method will take the command user has entered and will execute the class of that shape or function.
        /// </summary>
        /// <param name="g">It is the graphic variable that will be used to pass to the shapes class in order for them to draw the shape</param>
        /// <param name="cmd">It is the command that is entered which will determine what drawing has to be done</param>
        /// <param name="fillvalue">It is fill value to know whether to make the shape filled or just with outline.</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception></exception>
        public void draw(Graphics g ,String cmd,String fillvalue)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            Pen pen = new Pen(Color.Black);
            Brush brush = new SolidBrush(Color.Black);

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
            
            if (commandlist.Contains(split_command[0]))
            {
                
                    switch (split_command[0])
                    {
                        case "circle":
                            Circle c = new Circle(int.Parse(split_command[1]));
                            if (fillvalue == "on")
                            {
                                c.drawfill(g, brush, xpos, ypos);
                            }
                            else
                            {
                                c.draw(g, pen, xpos, ypos);
                            }
                            break;

                        case "rectangle":
                            rectangle rect = new rectangle(int.Parse(split_command[1]), int.Parse(split_command[2]));

                            if (fillvalue == "on")
                            {
                                rect.drawfill(g, brush, xpos, ypos);
                            }
                            else
                            {
                                rect.draw(g, pen, xpos, ypos);
                            }
                            break;

                        case "square":
                            rectangle sq = new rectangle(int.Parse(split_command[1]), int.Parse(split_command[2]));
                            if (fillvalue == "on")
                            {
                                sq.drawfill(g, brush, xpos, ypos);
                            }
                            else
                            {
                                sq.draw(g, pen, xpos, ypos);
                            }
                            break;

                        case "triangle":
                            triangle tr = new triangle(g, pen);
                            if (fillvalue == "on")
                            {
                            String[] first_value = split_command[1].Split(',');
                            String[] second_value = split_command[2].Split(',');
                            String[] third_value = split_command[3].Split(',');
                            tr.drawfill(g, brush, xpos, ypos, int.Parse(first_value[0]), int.Parse(first_value[1]), int.Parse(second_value[0]), int.Parse(second_value[1]), int.Parse(third_value[0]), int.Parse(third_value[1]));
                            }
                            else
                            {
                            String[] first_value = split_command[1].Split(',');
                            String[] second_value = split_command[2].Split(',');
                            String[] third_value = split_command[3].Split(',');
                            tr.draw(g, pen, xpos, ypos, int.Parse(first_value[0]), int.Parse(first_value[1]), int.Parse(second_value[0]), int.Parse(second_value[1]), int.Parse(third_value[0]), int.Parse(third_value[1]));
                            }
                            break;

                        case "clear":
                            clear cl = new clear();
                            cl.draw(g);
                            break;

                        case "drawto":
                            int X = int.Parse(split_command[1]);
                            int Y = int.Parse(split_command[2]);
                            g.DrawLine(pen, xpos, ypos, X, Y);
                            xpos = int.Parse(split_command[1]);
                            ypos = int.Parse(split_command[2]);

                            break;

                        
                    default:
                            break;
                    }

                }
                
                
            else
            {
                try
                {
                    throw new Not_a_valid_command_exception(g, 0);
                }
                catch { }
            }
            
        }

    }
}