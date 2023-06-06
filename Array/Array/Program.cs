using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String s1 = "So";
            String s2 = "ma";
            Console.WriteLine(string.Concat(s1,s2));           
            int [] arr=new int[3];
            arr[0]=1;
            arr[1]=2;
            arr[2]=3;
            for(int i = 0; i < 4; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
