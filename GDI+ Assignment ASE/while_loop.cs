using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class while_loop
    {
        String condition;
        public while_loop(string condition)
        {
            this.condition = condition;
        }
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
