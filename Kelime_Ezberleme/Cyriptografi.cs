using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kelime_Ezberleme
{
    public  class Cyriptografi
    {
        public static string Encyripto(string text,int key)
        {
            var x = text.ToCharArray();
            var temp = "";
            foreach (var item in x)
            {
                temp += Convert.ToChar((item + key));
            }
            return temp;
        }
        public static string Decyripto(string text, int key)
        {
            var x = text.ToCharArray();
            var temp = "";
            foreach (var item in x)
            {
                temp += Convert.ToChar((item - key));
            }
            return temp;
        }
    }
}
