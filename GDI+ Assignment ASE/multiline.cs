using GDI__Assignment_ASE.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GDI__Assignment_ASE
{
    public class multiline
    {
        String code;
        String fillvalue;
        List<string>vars = new List<string>();
        List<string>values = new List<string>();
        Graphics g;

        public multiline(String code, Graphics g, String filvalue)
        {
            this.code = code;
            this.g = g;
            this.fillvalue = filvalue;
        }

        public string variables()
        {

            List<string> commandlist = new List<string>();
            commandlist.Add("circle");
            commandlist.Add("rectangle");
            commandlist.Add("triangle");
            commandlist.Add("square");
            commandlist.Add("drawto");
            commandlist.Add("clear");

            String[] lines = code.Split('\n');

            
            for (int i = 0; i < lines.Length; i++)
            {
                String[] split_command = lines[i].Split(' ');




                // Shape Drawing Condition ----------------------------------------------------------------------


                if (commandlist.Contains(split_command[0]))
                {
                    split_command[0].ToLower();
                    switch (split_command[0])
                    {
                        case "circle":
                            if (int.TryParse(split_command[1], out _))
                            {
                                Drawing d = new Drawing();
                                d.draw(g, lines[i], fillvalue);
                            }
                            else if (vars.Contains(split_command[1]))
                            {
                                int element = vars.IndexOf(split_command[1]);
                                String circle_command = split_command[0] + " " + values[element];
                                Drawing d = new Drawing();
                                d.draw(g, circle_command, fillvalue);
                            }
                            break;

                        case "rectangle":
                            if (int.TryParse(split_command[1], out _) && int.TryParse(split_command[2], out _))
                            {
                                Drawing d = new Drawing();
                                d.draw(g, lines[i], fillvalue);
                            }
                            else if (vars.Contains(split_command[1]) && vars.Contains(split_command[2]))
                            {
                                int element = vars.IndexOf(split_command[1]);
                                int element2 = vars.IndexOf(split_command[2]);
                                String rect_command = split_command[0] + " " + values[element] + " " + values[element2];
                                Drawing d = new Drawing();
                                d.draw(g, rect_command, fillvalue);
                            }
                            break;

                        case "square":
                            if (int.TryParse(split_command[1], out _) && int.TryParse(split_command[2], out _))
                            {
                                Drawing d = new Drawing();
                                d.draw(g, lines[i], fillvalue);
                            }
                            else if (vars.Contains(split_command[1]) && vars.Contains(split_command[2]))
                            {
                                int element = vars.IndexOf(split_command[1]);
                                int element2 = vars.IndexOf(split_command[2]);
                                String square_command = split_command[0] + " " + values[element] + " " + values[element2];
                                Drawing d = new Drawing();
                                d.draw(g, square_command, fillvalue);
                            }
                            break;

                        case "clear":
                            if (lines[i] == "clear")
                            {
                                Drawing d = new Drawing();
                                d.draw(g, lines[i], fillvalue);
                            }
                            break;

                        case "drawto":
                            if (int.TryParse(split_command[1], out _) && int.TryParse(split_command[2], out _))
                            {
                                Drawing d = new Drawing();
                                d.draw(g, lines[i], fillvalue);
                            }
                            else if (vars.Contains(split_command[1]) && vars.Contains(split_command[2]))
                            {
                                int element = vars.IndexOf(split_command[1]);
                                int element2 = vars.IndexOf(split_command[2]);
                                String drawto = split_command[0] + " " + values[element] + " " + values[element2];
                                Drawing d = new Drawing();
                                d.draw(g, drawto, fillvalue);
                            }
                            break;
                        default: break;
                    }
                }




                // Variable Creation ----------------------------------------------------------------------


                if (split_command.Contains("="))
                {
                        vars.Add(split_command[0]);
                        values.Add(split_command[2]);
                    
                }



                // Print Condition ----------------------------------------------------------------------


                else if (split_command[0].Equals("print"))
                {
                    if (split_command.Length == 2 && vars.Contains(split_command[1]))
                    {
                        int element = vars.IndexOf(split_command[1]);
                        if (element >= 0)
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString(values[element], f, Brushes.Red, new Point(50, 50));
                        }
                    }
                    else if (split_command.Length == 4 && vars.Contains(split_command[1]) && vars.Contains(split_command[3]) && (split_command[2] == "+" || split_command[2] == "-" || split_command[2] == "*" || split_command[2] == "/"))
                    {
                        int variable1 = vars.IndexOf(split_command[1]);
                        int variable2 = vars.IndexOf(split_command[3]);
                        int value1 = int.Parse(values[variable1]);
                        int value2 = int.Parse(values[variable2]);

                        if (split_command[2] == "+")
                        {
                            int result = value1 + value2;
                            Font f = new Font("Arial", 14);
                            g.DrawString(result.ToString(), f, Brushes.Red, new Point(50, 50));
                        }
                        if (split_command[2] == "-")
                        {
                            int result = value1 - value2;
                            Font f = new Font("Arial", 14);
                            g.DrawString(result.ToString(), f, Brushes.Red, new Point(50, 50));
                        }
                        if (split_command[2] == "*")
                        {
                            int result = value1 * value2;
                            Font f = new Font("Arial", 14);
                            g.DrawString(result.ToString(), f, Brushes.Red, new Point(50, 50));
                        }
                        if (split_command[2] == "/")
                        {
                            int result = value1 / value2;
                            Font f = new Font("Arial", 14);
                            g.DrawString(result.ToString(), f, Brushes.Red, new Point(50, 50));
                        }
                    }
                }



                // Increament/Decreament Condition ----------------------------------------------------------------------


                if (vars.Contains(split_command[0]) && split_command[1] == "="  && (split_command[2] == split_command[0]))
                {
                  
                    variables_operation vo = new variables_operation(values,vars);
                    int element = vars.IndexOf(split_command[2]);
                    values[element] = vo.new_value(lines[i]);
                }



                // If Condition ----------------------------------------------------------------------


                if (split_command[0] == "if")
                {
                    if_condition ifc = new if_condition(g, split_command[2]);
                    String valid = ifc.if_statement();
                    if (valid == "false")
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("Invalid 'if' command", f, Brushes.Red, new Point(50, 50));
                    }


                    else
                    {
                        if (vars.Contains(split_command[1]))
                        {
                            int element = vars.IndexOf(split_command[1]);

                            if (valid == "==")
                            {
                                if (values[element] == split_command[3])
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endif")
                                        {
                                            i = j; break;
                                        }
                                        else
                                        { 
                                            String[] if_commands = lines[j].Split(' ');
                                            if (if_commands[0] == "circle")
                                            {
                                                if (vars.Contains(if_commands[1]))
                                                {
                                                    Font f = new Font("Arial", 14);
                                                    g.DrawString(if_commands[1], f, Brushes.Red, new Point(50, 50));
                                                }
                                                else
                                                {
                                                    Font f = new Font("Arial", 14);
                                                    g.DrawString("Not Found", f, Brushes.Red, new Point(50, 50));
                                                }
                                                /*String circle_command = if_commands[0] + " " + values[elem];
                                                  Drawing d = new Drawing();
                                                  d.draw(g, circle_command, fillvalue);*/
                                            }
                                        }

                                    }
                                }
                            }
                            else
                            {
                                for (int j = i + 1; j < lines.Length; j++)
                                {
                                    if (lines[j].Trim() == "endif")
                                    {
                                        i = j;
                                    }
                                }
                            }
                        }
                        else if (lines[i] == "endif")
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString(valid, f, Brushes.Red, new Point(50, 50));
                        }
                        
                        
                    }

                }


                // While Loop ----------------------------------------------------------------------

                if (split_command[0] == "while")
                {
                    if (vars.Contains(split_command[1]) && vars.Contains(split_command[3]))
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("Both are variables", f, Brushes.Red, new Point(50, 50));
                    }
                    else if (vars.Contains(split_command[1]) || vars.Contains(split_command[3]))
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("Only one is a variable", f, Brushes.Red, new Point(50, 50));
                    }
                    else
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("None are variables", f, Brushes.Red, new Point(50, 50));
                    }
                }

            }//for loop end
            return "hello";
        }
    }
}



/*for (int j = i + 1; j < lines.Length; j++)
                    {
                        if (lines[j].Trim() == "endif")
                        {
                            Font f = new Font("Arial", 14);
                            g.DrawString("Hello there", f, Brushes.Red, new Point(50, 50));
                        }
                            String[] for_loop_command = lines[j].Split(' ');
                            if (for_loop_command[0] == "circle")
                            {
                                if (vars.Contains(for_loop_command[1]))
                                {
                                    Font f = new Font("Arial", 14);
                                    g.DrawString("obiwan", f, Brushes.Red, new Point(50, 50));

                                }
                            }
                        
                    }*/


/*  
                                            String[] split_command_if = lines[j].Split(' ');
                                            if (commandlist.Contains(split_command_if[0]))
                                            {
                                                split_command_if[0].ToLower();
                                                switch (split_command_if[0])
                                                {
                                                    case "circle":
                                                        if (int.TryParse(split_command_if[1], out _))
                                                        {
                                                            Drawing d = new Drawing();
                                                            d.draw(g, lines[j], fillvalue);
                                                        }
                                                        else if (vars.Contains(split_command_if[1]))
                                                        {
                                                            int _element = Array.IndexOf(vars, split_command_if[1]);
                                                            String circle_command = split_command_if[0] + " " + values[_element];
                                                            Drawing d = new Drawing();
                                                            d.draw(g, circle_command, fillvalue);
                                                        }
                                                        break;

                                                    case "rectangle":
                                                        if (int.TryParse(split_command_if[1], out _) && int.TryParse(split_command_if[2], out _))
                                                        {
                                                            Drawing d = new Drawing();
                                                            d.draw(g, lines[j], fillvalue);
                                                        }
                                                        else if (vars.Contains(split_command_if[1]) && vars.Contains(split_command_if[2]))
                                                        {
                                                            int _element = Array.IndexOf(vars, split_command_if[1]);
                                                            int element2 = Array.IndexOf(vars, split_command_if[2]);
                                                            String rect_command = split_command_if[0] + " " + values[_element] + " " + values[element2];
                                                            Drawing d = new Drawing();
                                                            d.draw(g, rect_command, fillvalue);
                                                        }
                                                        break;

                                                    case "square":
                                                        if (int.TryParse(split_command_if[1], out _) && int.TryParse(split_command_if[2], out _))
                                                        {
                                                            Drawing d = new Drawing();
                                                            d.draw(g, lines[j], fillvalue);
                                                        }
                                                        else if (vars.Contains(split_command_if[1]) && vars.Contains(split_command_if[2]))
                                                        {
                                                            int _element = Array.IndexOf(vars, split_command_if[1]);
                                                            int element2 = Array.IndexOf(vars, split_command_if[2]);
                                                            String square_command = split_command_if[0] + " " + values[_element] + " " + values[element2];
                                                            Drawing d = new Drawing();
                                                            d.draw(g, square_command, fillvalue);
                                                        }
                                                        break;

                                                    case "clear":
                                                        if (lines[j] == "clear")
                                                        {
                                                            Drawing d = new Drawing();
                                                            d.draw(g, lines[j], fillvalue);
                                                        }
                                                        break;

                                                    case "drawto":
                                                        if (int.TryParse(split_command_if[1], out _) && int.TryParse(split_command_if[2], out _))
                                                        {
                                                            Drawing d = new Drawing();
                                                            d.draw(g, lines[j], fillvalue);
                                                        }
                                                        else if (vars.Contains(split_command_if[1]) && vars.Contains(split_command_if[2]))
                                                        {
                                                            int _element = Array.IndexOf(vars, split_command_if[1]);
                                                            int element2 = Array.IndexOf(vars, split_command_if[2]);
                                                            String drawto = split_command_if[0] + " " + values[_element] + " " + values[element2];
                                                            Drawing d = new Drawing();
                                                            d.draw(g, drawto, fillvalue);
                                                        }
                                                        break;
                                                    default: break;
                                                }
                                            }

                                            if (split_command_if[0].Equals("print"))
                                            {
                                                
                                                if (split_command_if.Length == 2 && vars.Contains(split_command_if[1]))
                                                {
                                                    int elem = Array.IndexOf(vars, split_command_if[1]);
                                                    if (elem >= 0)
                                                    {
                                                        Font f = new Font("Arial", 14);
                                                        g.DrawString(values[elem], f, Brushes.Red, new Point(50, 50));
                                                    }
                                                }
                                                else if (split_command_if.Length == 4 && vars.Contains(split_command_if[1]) && vars.Contains(split_command_if[3]) && (split_command_if[2] == "+" || split_command_if[2] == "-" || split_command_if[2] == "*" || split_command_if[2] == "/"))
                                                {
                                                    int variable1 = Array.IndexOf(vars, split_command_if[1]);
                                                    int variable2 = Array.IndexOf(vars, split_command_if[3]);
                                                    int value1 = int.Parse(values[variable1]);
                                                    int value2 = int.Parse(values[variable2]);

                                                    if (split_command_if[2] == "+")
                                                    {
                                                        int result = value1 + value2;
                                                        Font f = new Font("Arial", 14);
                                                        g.DrawString(result.ToString(), f, Brushes.Red, new Point(50, 50));
                                                    }
                                                    if (split_command_if[2] == "-")
                                                    {
                                                        int result = value1 - value2;
                                                        Font f = new Font("Arial", 14);
                                                        g.DrawString(result.ToString(), f, Brushes.Red, new Point(50, 50));
                                                    }
                                                    if (split_command_if[2] == "*")
                                                    {
                                                        int result = value1 * value2;
                                                        Font f = new Font("Arial", 14);
                                                        g.DrawString(result.ToString(), f, Brushes.Red, new Point(50, 50));
                                                    }
                                                    if (split_command_if[2] == "/")
                                                    {
                                                        int result = value1 / value2;
                                                        Font f = new Font("Arial", 14);
                                                        g.DrawString(result.ToString(), f, Brushes.Red, new Point(50, 50));
                                                    }
                                                }
                                            }
                                        */