using System;

namespace Constructor_Q1
{
    class Employee
    {
        int id;
        string empname;
        //there are two types of constructur default and parameterized 
        public Employee()
        {
            // Default constructor 
            id = 0;
            empname = "Empty Name";
            Console.WriteLine(id + " " + empname);
        }

        public Employee(int id, string name)
        {   //parameterized constructor
            this.id = id;
            this.empname = name;
            Console.WriteLine(id + " " + name);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee(); // by using the default constructor
            Employee employee2 = new Employee(1, "Soma"); // by using the parameterized constructor
            Console.ReadKey();
        }
    }
}
