using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Primitive_And_non_Primitive_datatypes
{
    internal class Program
    {
        //struct
        public struct Add
        {
            public int a;
            public int b;
            public int c;

        }
        static void Main(string[] args)
        {
            Console.WriteLine("following are the primitive data types in c# \nrange of byte is " + byte.MinValue + " to "+byte.MaxValue);
            Console.WriteLine("range of int is from "+int.MinValue+" to "+int.MaxValue);
            Console.WriteLine("range of double is from "+double.MinValue+" to "+double.MaxValue);
            Console.WriteLine("range of long is from "+long.MinValue+" to "+long.MaxValue);
            Console.WriteLine("range of decimal"+decimal.MinValue+" to "+decimal.MaxValue);
            Console.WriteLine("range of short is from "+short.MinValue+" to "+short.MaxValue);
            Console.WriteLine("range of float is from "+float.MinValue+" to "+float.MaxValue);
            Console.WriteLine("range of char is from "+char.MinValue+" to "+char.MaxValue);
            Console.WriteLine(true +" "+ false);

            //followings are non primitive datatypes
            string s = "Soma";
            s.Trim('o','a');
            Console.WriteLine(s);

            //array datatype
            int[] arr=new int[3];
            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            Console.WriteLine("Elements in Array are ");
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
            //stack datatype
            Stack<int> stack = new Stack<int>();
            stack.Push(6);
            stack.Push(5);
            stack.Push(4);
            Console.WriteLine("stack is");
            foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
            //datatype queue

            Queue<int> queue = new Queue<int>();
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(9);
            Console.WriteLine("Queue is");
            foreach(int i in queue)
            {
                Console.WriteLine(i);
            }
            //LinkedList 
            LinkedList<int> list = new LinkedList<int>();
            list.AddFirst(10);
            list.AddLast(11);
            list.AddLast(12);
            Console.WriteLine("Linked list is");
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }
            //struct
            Add add;
            add.a = 10;
            add.b = 11;
            add.c = add.a + add.b;
            Console.WriteLine("This is struct "+add.c);
            
            //struct allow you to encapsulate the related information into single unit and it is immutable

            
            Console.ReadLine();
        }
    }
}
