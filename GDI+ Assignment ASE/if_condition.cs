using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This is the class to check the condition for "if" condition.
    /// </summary>
    public class if_condition
    {

        String condition;
        Char[] characters;
        Graphics g;
        /// <summary>
        /// This constructor will take Graphics element for exception purposes and the condition in 
        /// string value to check.
        /// </summary>
        /// <param name="g">The graphics element</param>
        /// <param name="condition">The if condition to be checked</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>
        public if_condition(Graphics g, String condition)
        {
            if (g is null)
            {
                throw new ArgumentNullException(nameof(g));
            }
            this.condition = condition;
            this.g = g;
        }
        /// <summary>
        /// This method contains a list of all possible if conditions and it will check the passed condition in the list
        /// and return the condition as String if the value exists in the list.
        /// </summary>
        /// <returns>Returns the String value of the ccondition or returns false if the condition is not present in the list</returns>
        public String if_statement()
        {
            List<String> list = new List<String>();
            list.Add("==");
            list.Add("<=");
            list.Add(">=");
            list.Add(">");
            list.Add("<");
            list.Add("!=");
            if (list.Contains(condition))
            {
                return condition;
            }
            else
            {
                return "false";
            }
        } 
    }
}
