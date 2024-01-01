using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class syntax_checking
    {
        public int check(String command , Graphics g)
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

            try
            {
                if (commandlist.Contains(split_command[0]))
                {
                    if (cmdline == "")
                    {
                        throw new cmdline_empty_exception(g);
                    }

                    if (split_command[0] == "circle")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 2 && int.TryParse(split_command[1], out _))
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new circle_exception(g);
                        }
                    }


                    if (split_command[0] == "rectangle" || split_command[0] == "sqaure")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 3 && int.TryParse(split_command[1], out _) && int.TryParse(split_command[2], out _))
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new rectangle_sqaure_exception(g);
                        }
                    }


                    if (split_command[0] == "triangle")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 4)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new triangle_exception(g);
                        }
                    }


                    if (split_command[0] == "clear")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 1)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new clear_exception(g);
                        }
                    }


                    if (split_command[0] == "reset")
                    {
                        int total_ele = split_command.Count();
                        if (total_ele == 1)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("The Syntax is correct", f, Brushes.Red, new Point(50, 50));
                        }
                        else
                        {
                            throw new reset_exception(g);
                        }
                    }
                }
                else
                {
                    throw new Not_a_valid_command_exception(g);
                }
            }
            catch
            {

            }
            return flag;
        }
    }
}
