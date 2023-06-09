using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Collections_inC_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //system.collections.genric have genaric classes and interface like followinng
            //first class is list it is allow you to add and remove element dnyamically we need not to specify size of list
            //list can be accessed by using its index

            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            list.Remove(list[1]);
            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            SortedSet<int> sortedset= new SortedSet<int>();
            sortedset.Add(11);
            sortedset.Add(11);
            sortedset.Add(222);   
            sortedset.Add(34);
            sortedset.Add(42);
            foreach(int i in sortedset)
            {
                Console.WriteLine(i);
            }
            //dictionary
            Dictionary<int,string> dict= new Dictionary<int,string>();
            dict.Add(1, "Soma");
            dict.Add(2, "Barge");
            Console.WriteLine(dict[1]);

            //LinkedList
            LinkedList<string> List=new LinkedList<string>();
            List.AddLast("I");
            List.AddLast("Love");
            List.AddLast("Nimap");

            foreach(string i in List)
            {
                Console.Write(i+" ");
            }
            //hash
            String s = "Somanath";
            int hashCode=s.GetHashCode();
            Console.Write("\n"+s+" "+hashCode);

            //hashset
            HashSet<int> set= new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(3);
            foreach(int i in set)
            {
                int x = set.GetHashCode();
                Console.WriteLine("\n"+i+" = "+x);
            }

            Console.ReadLine();
        }
    }
}
