using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    /// <summary>
    /// This class will check whether the condition of while loop is correct or not
    /// </summary>
    public class while_loop
    {

        String condition;
        /// <summary>
        /// This constructor will take the condition and check whether it's null or not
        /// </summary>
        /// <param name="condition">The condtion passed in the while loop</param>
        /// <exception cref="ArgumentNullException">An exception to be thrown if the graphic variable is null</exception>

        public while_loop(string condition)
        {
            if (condition is null)
            {
                throw new ArgumentNullException(nameof(condition));
            }
            this.condition = condition;
        }
        /// <summary>
        /// This will contain a list of all possible values of the condition and it will check if the 
        /// condition is correct.
        /// </summary>
        /// <returns>It will return the string format of the condition if the condition is present in the list and will return false
        /// if the condition is not in the list.</returns>
        public String validation()
        {
            List<String> list = new List<String>();
            list.Add("==");
            list.Add("<=");
            list.Add(">=");
            list.Add("!=");
            list.Add(">");
            list.Add("<");

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
