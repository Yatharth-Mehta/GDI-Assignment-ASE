using GDI__Assignment_ASE;
using GDI__Assignment_ASE.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GDI__Assignment_ASE
{/// <summary>
/// This is a class for multiline box commands where the commands passed 
/// in the multiline textbox will be checked one by one and will be executed.
/// </summary>
    public class multiline
    {
        String code;
        String fillvalue;
        List<string> vars = new List<string>();
        List<string> values = new List<string>();
        List<string> meth_vars= new List<string>();
        List<string> meth_values = new List<string>();
        List<string> methods= new List<string>();
        List<string> method_commands= new List<string>();
        Graphics g;

        /// <summary>
        /// A constructor is created which will take value of fill , the whole code written in the multiline box and the Graphics
        /// to draw and will assign to the global class variables.
        /// </summary>
        /// <param name="code">The whole multiline box text</param>
        /// <param name="g">The graphic variabe needed to draw</param>-
        /// <param name="fillvalue">The fillvalue in order to know whetheer the shape is to be drawn with
        /// fill or without fill</param>
        public multiline(String code, Graphics g, String fillvalue)
        {
            this.code = code;
            this.g = g;
            this.fillvalue = fillvalue;
        }

     /// <summary>
     /// This is the main method which will check the conditions and will run the commands by calling their respective class, this will include all the drawing as well as print , while loop , if condition and methods.
     /// </summary>
     /// <exception cref="ArgumentNullException"></exception>
        public void multiline_main()
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
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

                        case "triangle":
                            String[] first_value = split_command[1].Split(',');
                            String[] second_value = split_command[2].Split(',');
                            String[] third_value = split_command[3].Split(',');
                            if ((int.TryParse(first_value[0], out _) && int.TryParse(first_value[1], out _)) && (int.TryParse(second_value[0], out _) && int.TryParse(second_value[1], out _)) && (int.TryParse(third_value[0], out _) && int.TryParse(third_value[1], out _)))
                            {
                                Drawing d = new Drawing();
                                d.draw(g, lines[i], fillvalue);
                            }
                            else if (vars.Contains(first_value[0]) && vars.Contains(first_value[1]) && vars.Contains(second_value[0]) && vars.Contains(second_value[1]) && vars.Contains(third_value[0]) && vars.Contains(third_value[1]))
                            {
                                int element = vars.IndexOf(first_value[0]);
                                int element1 = vars.IndexOf(first_value[1]);
                                int element2 = vars.IndexOf(second_value[0]);
                                int element3 = vars.IndexOf(second_value[1]);
                                int element4 = vars.IndexOf(third_value[0]);
                                int element5 = vars.IndexOf(third_value[1]);
                                String square_command = split_command[0] + " " + values[element] + "," + values[element1] + " " + values[element2] + "," + values[element3] + " " + values[element4] + "," + values[element5] ;
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
                

                if (vars.Contains(split_command[0]) && split_command[1] == "=" && (split_command[2] == split_command[0]))
                {
                    variables_operation vo = new variables_operation(values, vars);
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
                        if (vars.Contains(split_command[1]) && int.TryParse(split_command[3],out _))
                        {
                            int element_ = vars.IndexOf(split_command[1]);
                            if (valid == "==")
                            {
                                if (values[element_] == split_command[3])
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endif")
                                        {
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                            icc.cmds();
                                        }
                                    }
                                }
                            }


                            else if (valid == ">")
                            {
                                if (int.Parse(values[element_]) > int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endif")
                                        {
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                            icc.cmds();
                                        }
                                    }
                                }
                            }


                            else if (valid == "<")
                            {
                                if (int.Parse(values[element_]) < int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endif")
                                        {
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                            icc.cmds();
                                        }
                                    }
                                }
                            }


                            else if (valid == "!=")
                            {
                                if (int.Parse(values[element_]) != int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endif")
                                        {
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                            icc.cmds();
                                        }
                                    }
                                }
                            }



                            else if (valid == ">=")
                            {
                                if (int.Parse(values[element_]) >= int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endif")
                                        {
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                            icc.cmds();
                                        }
                                    }
                                }
                            }


                            else if (valid == "<=")
                            {
                                if (int.Parse(values[element_]) <= int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endif")
                                        {
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                            icc.cmds();
                                        }
                                    }
                                }
                            }

                        }



                        else if (vars.Contains(split_command[1]))
                        {
                            String sec_ele_present = split_command[3].Trim();
                            if (vars.Contains(sec_ele_present))
                            {
                                int element_ = vars.IndexOf(split_command[1]);
                                int second_element = vars.IndexOf(sec_ele_present);
                                if (valid == "==")
                                {
                                    if (int.Parse(values[element_]) == int.Parse(values[second_element]))
                                    {
                                        for (int j = i + 1; j < lines.Length; j++)
                                        {
                                            if (lines[j].Trim() == "endif")
                                            {
                                                i = j; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[j];
                                                if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                                icc.cmds();
                                            }
                                        }
                                    }
                                }


                                if (valid == ">")
                                {
                                    if (int.Parse(values[element_]) > int.Parse(values[second_element]))
                                    {
                                        for (int j = i + 1; j < lines.Length; j++)
                                        {
                                            if (lines[j].Trim() == "endif")
                                            {
                                                i = j; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[j];
                                                if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                                icc.cmds();
                                            }
                                        }
                                    }
                                }


                                if (valid == "<")
                                {
                                    if (int.Parse(values[element_]) < int.Parse(values[second_element]))
                                    {
                                        for (int j = i + 1; j < lines.Length; j++)
                                        {
                                            if (lines[j].Trim() == "endif")
                                            {
                                                i = j; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[j];
                                                if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                                icc.cmds();
                                            }
                                        }
                                    }
                                }


                                if (valid == "!=")
                                {
                                    if (int.Parse(values[element_]) != int.Parse(values[second_element]))
                                    {
                                        for (int j = i + 1; j < lines.Length; j++)
                                        {
                                            if (lines[j].Trim() == "endif")
                                            {
                                                i = j; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[j];
                                                if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                                icc.cmds();
                                            }
                                        }
                                    }
                                }



                                if (valid == ">=")
                                {
                                    if (int.Parse(values[element_]) >= int.Parse(values[second_element]))
                                    {
                                        for (int j = i + 1; j < lines.Length; j++)
                                        {
                                            if (lines[j].Trim() == "endif")
                                            {
                                                i = j; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[j];
                                                if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                                icc.cmds();
                                            }
                                        }
                                    }
                                }


                                if (valid == "<=")
                                {
                                    if (int.Parse(values[element_]) <= int.Parse(values[second_element]))
                                    {
                                        for (int j = i + 1; j < lines.Length; j++)
                                        {
                                            if (lines[j].Trim() == "endif")
                                            {
                                                i = j; break;
                                            }
                                            else
                                            {
                                                String inside_loop = lines[j];
                                                if_condition_calling icc = new if_condition_calling(inside_loop, g, fillvalue, vars, values);
                                                icc.cmds();
                                            }
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

                }



                // While Loop ----------------------------------------------------------------------


                if (split_command[0] == "while")
                {
                    while_loop wl = new while_loop(split_command[2]);
                    String condition = wl.validation();

                    if (condition == "false")
                    {
                        Font f = new Font("Arial", 14);
                        g.DrawString("Invalid While condition", f, Brushes.Red, new Point(50, 50));
                    }

                    if (condition != "false")
                    {
                        if (vars.Contains(split_command[1]))
                        {


                            if (condition == "==")
                            {
                                int element_ = vars.IndexOf(split_command[1]);
                                while (values[element_] == split_command[3])
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endloop")
                                        {
                                            while_iteration wi = new while_iteration(lines[i],g,fillvalue);
                                            wi.iterate();
                                            i = j; 
                                            break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            while_calling wc = new while_calling(inside_loop, g, fillvalue, vars, values);
                                            wc.cmds();
                                        }
                                    }
                                }
                            }



                            if (condition == ">")
                            {
                                int element_ = vars.IndexOf(split_command[1]);
                                if (int.Parse(values[element_]) > int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endloop")
                                        {
                                            while_iteration wi = new while_iteration(lines[i], g, fillvalue);
                                            wi.iterate();
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            while_calling wc = new while_calling(inside_loop, g, fillvalue, vars, values);
                                            wc.cmds();
                                        }
                                    }
                                }
                            }

                            if (condition == "<")
                            {
                                int element_ = vars.IndexOf(split_command[1]);
                                if (int.Parse(values[element_]) < int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endloop")
                                        {
                                            while_iteration wi = new while_iteration(split_command[0]+ " " + split_command[1] + " " + split_command[2] + " " + split_command[3], g, fillvalue);
                                            wi.iterate();
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            while_calling wc = new while_calling(inside_loop, g, fillvalue, vars, values);
                                            wc.cmds();
                                        }
                                    }
                                }
                            }

                            if (condition == "!=")
                            {
                                int element_ = vars.IndexOf(split_command[1]);
                                if (int.Parse(values[element_]) != int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endloop")
                                        {
                                            while_iteration wi = new while_iteration(lines[i], g, fillvalue);
                                            wi.iterate();
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            while_calling wc = new while_calling(inside_loop, g, fillvalue, vars, values);
                                            wc.cmds();
                                        }
                                    }
                                }
                            }

                            if (condition == "<=")
                            {
                                int element_ = vars.IndexOf(split_command[1]);
                                if (int.Parse(values[element_]) <= int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endloop")
                                        {
                                            while_iteration wi = new while_iteration(lines[i], g, fillvalue);
                                            wi.iterate();
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            while_calling wc = new while_calling(inside_loop, g, fillvalue, vars, values);
                                            wc.cmds();
                                        }
                                    }
                                }
                            }

                            if (condition == ">=")
                            {
                                int element_ = vars.IndexOf(split_command[1]);
                                if (int.Parse(values[element_]) >= int.Parse(split_command[3]))
                                {
                                    for (int j = i + 1; j < lines.Length; j++)
                                    {
                                        if (lines[j].Trim() == "endloop")
                                        {
                                            while_iteration wi = new while_iteration(lines[i], g, fillvalue);
                                            wi.iterate();
                                            i = j; break;
                                        }
                                        else
                                        {
                                            String inside_loop = lines[j];
                                            while_calling wc = new while_calling(inside_loop, g, fillvalue, vars, values);
                                            wc.cmds();
                                        }
                                    }
                                }
                            }

                            else
                            {
                                for (int j = i + 1; j < lines.Length; j++)
                                {
                                    if (lines[j].Trim() == "endloop")
                                    {
                                        i = j;
                                    }
                                }
                            }
                        }
                    }
                }



                // Method Creation ----------------------------------------------------------------------


                if (split_command[0] == "method")
                {
                    String[] method_name = split_command[1].Trim().Split('(', ')');
                    String[] parameters = method_name[1].Trim().Split(',');
                    methods.Add(method_name[0] + "()");
                    if (parameters == null)
                    {
                        for (int j = i + 1; j < lines.Length; j++)
                        {
                            if (lines[j].Trim() == "endmethod")
                            {
                                i = j; break;
                            }
                            else
                            {
                                method_commands.Add(lines[j]);
                            }
                        }
                    }
                    else
                    {
                        for (int j = 0; j < parameters.Length; j++)
                        {
                            meth_vars.Add(parameters[j]);
                        }
                        for (int j = i + 1; j < lines.Length; j++)
                        {
                            if (lines[j].Trim() == "endmethod")
                            {
                                i = j; break;
                            }
                            else
                            {
                                method_commands.Add(lines[j]);
                            }
                        }
                    }
                }

                String pattern = @"^([a-zA-Z_]\w*)\(([\w,]+)\)?$";
                Match m = Regex.Match(split_command[0].Trim(), pattern);
                if (m.Success)
                {
                    String[] split_call = split_command[0].Trim().Split('(', ')');
                    String[] par = split_call[1].Split(',');
                    for (int j = 0; j < par.Length; j++)
                    {
                        meth_values.Add(par[j]);

                    }
                  
                    for (int j = 0; j < method_commands.Count(); j++)
                    {
                        method_calling_with_parametres mc = new method_calling_with_parametres(method_commands[j], g, fillvalue, meth_vars, meth_values);
                        mc.cmds();
                    }
                }

                if (methods.Contains(split_command[0]))
                {
                    for (int j = 0; j < method_commands.Count(); j++)
                    {
                        method_calling mc = new method_calling(method_commands[j], g, fillvalue, vars, values);
                        mc.cmds();
                    }
                }

            }//for loop end
        }
    }
}