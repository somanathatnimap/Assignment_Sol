using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stackz
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           stack is linear datastructure it works on FILO 
           */
            Console.WriteLine("Subject Names are :");
            Stack<string> stack = new Stack<string>();
            stack.Push("Science");
            stack.Push("Maths");
            stack.Push("Marathi");
            stack.Push("History");
            stack.Push("English");

            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }
            
            Console.WriteLine("Total Number of Subjects are "+ stack.Count);
            Console.ReadLine();
        }
    }
}