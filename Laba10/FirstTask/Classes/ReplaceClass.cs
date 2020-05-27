using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba10.FirstTask.Classes
{
    class Replace
    {
        public static void ToBackSlash(ref string str) { 
          str =  str.Replace('/','\\');
        }
        public static void ToDoubleSlash(ref string str)
        {
            if (str.Contains("/")) {
                string newStr = "";
                for (int i = 0; i < str.IndexOf('/'); i++)
                {
                    newStr += str[i];
                }
                newStr += '/' + '/';
                for (int i = str.IndexOf('/'); i < str.Length; i++)
                {
                    newStr += str[i];
                }
                str = newStr; 
            }
        }
        public static void ToUnderScore(ref string str)
        {
            string newStr = "";
            foreach (char i in str)
            {
                if (i != ' ') newStr += i;
                else
                    newStr += '_';
            }
            str = newStr;
        }
        public static void ToUpper(ref string str)
        {
            str = str.ToUpper();
        }
    }
}
