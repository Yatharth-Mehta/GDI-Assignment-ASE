using GDI__Assignment_ASE.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class if_condition_calling
    {
        String code;
        String fillvalue;
        Graphics g;
        List<string> vars = new List<string>();
        List<string> values = new List<string>();
        public if_condition_calling(String command, Graphics g, String fillvalue, List<string> vars, List<string> values)
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
           

        }
    }
}

