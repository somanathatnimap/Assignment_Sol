using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_Builder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*in c# there are multiple type of string concatination first is we can directly add string using + oprator 
             second is concat method it can add string using String.Concat(str1,str2) and third is using stringBuilder class
            we can use stringBuilder.Append(str1,str2,..) to concate string it is more efficient for so many string*/

            string s1 = "Soma";
            string s2 = "Barge";
            //this is how we can concat string using +oprator
            Console.WriteLine(s1+" "+s2);

            string s3 = "Viraj";
            string s4 = "Sankapal";
            Console.WriteLine(string.Concat(s3," ",s4));
            //this is how we can concatinate string using concate method
            //this is static way
            string s5 = "Vivek";
            string s6 = "Rokade";
            StringBuilder sb = new StringBuilder();
            sb.Append(s5);
            sb.Append(" ");
            sb.Append(s6);
            sb.Insert(12, "The Great's");
            //this will insert string in specific location
            sb.Remove(21, 2);
            Console.WriteLine(sb.ToString());
            /* this is how we can concatinate string using stringBuilder 
            and manupulate string ths is best and effective way to concatinate string we can also insert, remove and replace string 
            */

            Console.ReadLine();
        }
    }
}
//stringBuilder support multiple methods in c# this is best way to for concanitaion