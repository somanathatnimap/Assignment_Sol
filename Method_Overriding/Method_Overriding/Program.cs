using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Overriding
{
    internal class Program
    {
        class Semienglish
        {
            public int Add(int sub1, int sub2, int sub3)
            {
                int addition=sub1 + sub2+sub3;
                Console.WriteLine(addition);
                return addition;
            }
        }
        class Marathi:Semienglish
        {
            public int Add(int sub1, int sub2, int sub3)
            {
                int addition=sub1+sub2+sub3;
                Console.WriteLine(addition);
                return addition;
            }
        }
        static void Main(string[] args)
        {
            //method overriding is process of same method that was already declared in parrent class
            Semienglish semienglish = new Semienglish();
            Semienglish marathi = new Marathi();
            semienglish.Add(87,65,65);
            marathi.Add(82,77,55);
            Console.ReadLine();
        }
    }
}
