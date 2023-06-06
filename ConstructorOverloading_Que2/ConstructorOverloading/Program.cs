using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorOverloading
{
    internal class Program
    {
        /*
         constructor is special type of method its have same name as of class
        constructor overloading have ability to define multiple constructor in same class
        when you use constructor overloading you will get multiple options to define objects 
         */
        public class Info
        {
            public int id;
            public string name;
            public string password;
            public Info(int id) {
                this.id = id;
                Console.WriteLine(id);
            }
            public Info(int id,string name)
            {
                this.id=id;
                this.name = name;
                Console.WriteLine(id+" "+name);
            }
            public Info(int id,string name, string password) {
                this.id = id;
                this.name = name;
                this.password= password;
                Console.WriteLine(id+" "+name+" "+password);
            }
        }
        static void Main(string[] args)
        {
            Info info1 = new Info(1);
            Info info2 = new Info(1, "Somanath", "@123");
            Info info3 = new Info(1, "somanath");
            Console.ReadKey();
        }
    }
}
