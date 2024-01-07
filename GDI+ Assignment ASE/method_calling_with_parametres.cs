using GDI__Assignment_ASE.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This class is for method calling and it will be called whenever the method will contain arguements.
    /// </summary>
    public class method_calling_with_parametres
    {
        String code;
        String fillvalue;
        Graphics g;
        List<string> vars = new List<string>();
        List<string> values = new List<string>();

        /// <summary>
        /// This constructor will take values of the command , a graphic variable , fill value and take 2 lists.
        /// </summary>
        /// <param name="command">The command passed in the method block</param>
        /// <param name="g">The Graphic variable</param>
        /// <param name="fillvalue">Fill value to decide whether the object is to made with fill or without filled</param>
        /// <param name="vars">List of created variables</param>
        /// <param name="values">List of created variable's values</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>

        public method_calling_with_parametres(String command, Graphics g, String fillvalue, List<string> vars, List<string> values)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            this.code = command;
            this.fillvalue = fillvalue;
            this.g = g;
            this.vars = vars;
            this.values = values;
        }
        /// <summary>
        /// The method that will check the command and will call the class of the action.
        /// </summary>
        public void cmds()
        {
            String[] split_command = code.Split(' ');

            if (split_command[0] == "circle")
            {
                if (int.TryParse(split_command[1], out _))
                {
                    String circle = split_command[0].Trim() + " " + int.Parse(split_command[1]);
                    Drawing dr = new Drawing();
                    dr.draw(g, circle, fillvalue);
                }
                else
                {
                    int elem = vars.IndexOf(split_command[1].Trim());
                    String circle = split_command[0].Trim() + " " + values[elem].Trim();
                    Drawing dr = new Drawing();
                    dr.draw(g, circle, fillvalue);
                }
            }
            if (split_command[0] == "rectangle")
            {
                if (int.TryParse(split_command[1], out _))
                {
                    String rectangle = split_command[0].Trim() + " " + int.Parse(split_command[1]) + " " + int.Parse(split_command[2]);
                    Drawing dr = new Drawing();
                    dr.draw(g, rectangle, fillvalue);
                }
                else
                {
                    int elem = vars.IndexOf(split_command[1].Trim());
                    int elem_ = vars.IndexOf(split_command[2].Trim());
                    String rect = split_command[0].Trim() + " " + values[elem] + " " + values[elem_];
                    Drawing dr = new Drawing();
                    dr.draw(g, rect, fillvalue);
                }
            }

            if (split_command[0] == "drawto")
            {
                if (int.TryParse(split_command[1], out _))
                {
                    String drawto = split_command[0].Trim() + " " + int.Parse(split_command[1]) + " " + int.Parse(split_command[2]);
                    Drawing dr = new Drawing();
                    dr.draw(g, drawto, fillvalue);
                }
                else
                {
                    int elem = vars.IndexOf(split_command[1].Trim());
                    int elem_ = vars.IndexOf(split_command[2].Trim());
                    String drawto = split_command[0].Trim() + " " + values[elem] + " " + values[elem_];
                    Drawing dr = new Drawing();
                    dr.draw(g, drawto, fillvalue);
                }
            }

            if (split_command[0] == "square")
            {
                if (int.TryParse(split_command[1], out _))
                {
                    String rectangle = split_command[0].Trim() + " " + int.Parse(split_command[1]) + " " + int.Parse(split_command[2]);
                    Drawing dr = new Drawing();
                    dr.draw(g, rectangle, fillvalue);
                }
                else
                {
                    int elem = vars.IndexOf(split_command[1].Trim());
                    int elem_ = vars.IndexOf(split_command[2].Trim());
                    String rect = split_command[0].Trim() + " " + values[elem] + " " + values[elem_];
                    Drawing dr = new Drawing();
                    dr.draw(g, rect, fillvalue);
                }
            }

            if (split_command[0] == "clear")
            {
                String clear = split_command[0].Trim();
                Drawing dr = new Drawing();
                dr.draw(g, clear, fillvalue);
            }

            if (vars.Contains(split_command[0]) && split_command[1] == "=" && (split_command[2] == split_command[0]))
            {

                variables_operation vo = new variables_operation(values, vars);
                int element = vars.IndexOf(split_command[2]);
                values[element] = vo.new_value(code);
            }

            if (split_command[0] == "triangle")
            {
                String[] first_value = split_command[1].Split(',');
                String[] second_value = split_command[2].Split(',');
                String[] third_value = split_command[3].Split(',');
                if ((int.TryParse(first_value[0], out _) && int.TryParse(first_value[1], out _)) && (int.TryParse(second_value[0], out _) && int.TryParse(second_value[1], out _)) && (int.TryParse(third_value[0], out _) && int.TryParse(third_value[1], out _)))
                {
                    Drawing d = new Drawing();
                    d.draw(g, code, fillvalue);
                }
                else if (vars.Contains(first_value[0]) && vars.Contains(first_value[1]) && vars.Contains(second_value[0]) && vars.Contains(second_value[1]) && vars.Contains(third_value[0]) && vars.Contains(third_value[1]))
                {
                    int element = vars.IndexOf(first_value[0]);
                    int element1 = vars.IndexOf(first_value[1]);
                    int element2 = vars.IndexOf(second_value[0]);
                    int element3 = vars.IndexOf(second_value[1]);
                    int element4 = vars.IndexOf(third_value[0]);
                    int element5 = vars.IndexOf(third_value[1]);
                    String triangle_command = split_command[0] + " " + values[element] + "," + values[element1] + " " + values[element2] + "," + values[element3] + " " + values[element4] + "," + values[element5];
                    Drawing d = new Drawing();
                    d.draw(g, triangle_command, fillvalue);
                }
            }



        }
    }
}
