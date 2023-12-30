using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GDI__Assignment_ASE
{
    public class if_condition
    {
        String condition;
        Char[] characters;
        Graphics g;
        public if_condition(Graphics g, String condition)
        {
            this.condition = condition;
            this.g = g;
        }
        public String if_statement()
        {
            List<String> list = new List<String>();
            list.Add("==");
            list.Add("<=");
            list.Add(">=");
            list.Add(">");
            list.Add("<");
            list.Add("!=");
            //String op = characters[1].ToString() + characters[2].ToString(); 
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
