using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class syntax_checking_multiline
    {
        String code;
        String[] split_command;
        String[] lines
            ;
        public syntax_checking_multiline(String code)
        {
            this.code = code;
        }
        public void check()
        {
            lines = code.Split('\n');

            List<string> commands = new List<string>();
            commands.Add("circle");
            commands.Add("rectangle");
            commands.Add("triangle");
            commands.Add("clear");
            commands.Add("reset");
            commands.Add("drawto");
            commands.Add("moveto");
            commands.Add("if");
            commands.Add("endif");
            commands.Add("method");
            commands.Add("endmethod");
            commands.Add("while");
            commands.Add("endloop");

            for (int i = 0; i < lines.Length; i++)
            {
                split_command = lines[i].Split(' ');

            }
        }
    }
}
