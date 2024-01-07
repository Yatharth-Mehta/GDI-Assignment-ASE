using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This calss will perform the actions on created variables
    /// </summary>
    public class variables_operation
    {
        List<String> values;
        List<String> vars;
        /// <summary>
        /// This constructor will store the values locally.
        /// </summary>
        /// <param name="values">The value of the variable</param>
        /// <param name="vars">The variable on which the operation is to be performed</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public variables_operation(List<String> values , List<String> vars)
        {
            if (values is null)
            {
                throw new ArgumentNullException(nameof(values));
            }
            this.values = values;
            this.vars = vars;
        }
        /// <summary>
        /// This class will perform the arithmetic operations on the variable.
        /// </summary>
        /// <param name="operation">This is the operation the user wants to perform on the variable</param>
        /// <returns>This will return the upadated value in String format</returns>
        public void new_value(String operation)
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
