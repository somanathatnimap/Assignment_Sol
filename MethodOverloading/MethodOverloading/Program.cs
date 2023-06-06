using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Program
    {
        class Addition
        {
            public int Add(int a, int b)
            {
                return a + b;
            }
            public int Add(int a, int b, int c)
            {
                return a + b + c;
            }
            public int Add(int a,int b , int c, int d)
            { 
                return a + b + c + d;
            }
        }
        static void Main(string[] args)
        {
            Addition add = new Addition();
            Console.WriteLine(add.Add(1, 2));
            Console.WriteLine(add.Add(2, 3, 4));
            Console.WriteLine(add.Add(3, 4, 5, 6));
            Console.ReadLine();
        }
    }
}
