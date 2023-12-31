using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GDI__Assignment_ASE
{
    public class variables_operation
    {
        List<String> values;
        List<String> vars;
        public variables_operation(List<String> values , List<String> vars)
        {
            if (values is null)
            {
                throw new ArgumentNullException(nameof(values));
            }
            this.values = values;
            this.vars = vars;
        }
        public String new_value(String operation)
        {
            String[] split_command = operation.Split(' ');
            int element = vars.IndexOf(split_command[2]);

            if (split_command[3] == "+")
            {
                int a = int.Parse(split_command[4]);
                int b = int.Parse(values[element]);
                int new_value = a + b;
                return new_value.ToString();
            }
            if (split_command[3] == "-")
            {
                int a = int.Parse(split_command[4]);
                int b = int.Parse(values[element]);
                int new_value = b - a;
                return new_value.ToString();
            }
            if (split_command[3] == "*")
            {
                int a = int.Parse(split_command[4]);
                int b = int.Parse(values[element]);
                int new_value = a * b;
                return new_value.ToString();
            }
            if (split_command[3] == "/")
            {
                int a = int.Parse(split_command[4]);
                int b = int.Parse(values[element]);
                int new_value = a % b;
                return new_value.ToString();
            }
            return "hello"; 
        }
    }
}
