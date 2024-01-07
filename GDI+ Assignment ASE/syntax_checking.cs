using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This class is for the syntax checking , whenever the user will click the syntax button this class will be called.
    /// </summary>
    public class syntax_checking
    {
        /// <summary>
        /// This method will contain a List and will check whether the command is in the list and will tell that the command
        /// is correct is it is or will throw appropriate custom exceptions.
        /// </summary>
        /// <param name="command">The command passed by user.</param>
        /// <param name="g">Graphic element for drawing string on canvas</param>
        /// <param name="ypos">The position of the text on Y-axis</param>
        /// <returns>It will return a flag value of 1.</returns>
        public int check(String command, Graphics g, int ypos)
        {
            int flag = 1;
            String cmdline = command;
            cmdline = cmdline.ToLower();
            String[] split_command = cmdline.Split(' ');

            List<string> commandlist = new List<string>();
            commandlist.Add("circle");
            commandlist.Add("rectangle");
            commandlist.Add("triangle");
            commandlist.Add("square");
            commandlist.Add("moveto");
            commandlist.Add("drawto");
            commandlist.Add("clear");
            commandlist.Add("reset");
            commandlist.Add("if");
            commandlist.Add("while");
            commandlist.Add("method");
            commandlist.Add("endif");
            commandlist.Add("endloop");
            commandlist.Add("endmethod");

            try
            {
                if (commandlist.Contains(split_command[0]))
                {
                    if (cmdline == "")
                    {
                        throw new cmdline_empty_exception(g, ypos);
                    }

                    if (split_command[0] == "circle")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 2 && int.TryParse(split_command[1], out _))
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(0, ypos));
                        }
                        else
                        {
                            throw new circle_exception(g, ypos);
                        }
                    }


                    if (split_command[0] == "rectangle" || split_command[0] == "square")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 3 && int.TryParse(split_command[1], out _) && int.TryParse(split_command[2], out _))
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(0, ypos));
                        }
                        else
                        {
                            throw new rectangle_sqaure_exception(g, ypos);
                        }
                    }


                    if (split_command[0] == "triangle")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 4)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(0, ypos));
                        }
                        else
                        {
                            throw new triangle_exception(g, ypos);
                        }
                    }


                    if (split_command[0].Trim() == "clear")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 1)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(0, ypos));
                        }
                        else
                        {
                            throw new clear_exception(g, ypos);
                        }
                    }


                    if (split_command[0].Trim() == "reset")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 1)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(0, ypos));
                        }
                        else
                        {
                            throw new reset_exception(g, ypos);
                        }
                    }

                    if (split_command[0] == "if")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 4)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(0, ypos));
                        }
                        else
                        {
                            throw new if_exception(g, ypos);
                        }
                    }

                    if (split_command[0] == "while")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 4)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(0, ypos));
                        }
                        else
                        {
                            throw new while_exception(g, ypos);
                        }
                    }

                    if (split_command[0] == "method")
                    {
                        int total_ele = split_command.Count();
                        if (split_command[1].Contains('(') && split_command[1].Contains(')'))
                        {
                            if (total_ele == 2)
                            {
                                Font f = new Font("Arial", 14);
                                g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(0, ypos));
                            }
                        }
                        else
                        {
                            throw new method_exception(g, ypos);
                        }
                    }
                }
                else
                {
                    throw new Not_a_valid_command_exception(g, ypos);
                }
            }
            catch
            {

            }
            return flag;
        }
    }
}
