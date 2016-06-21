using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.ReadKey();
            string a1 = "\bHello";
            string b1 = "world";
            string c1 = "for the second time!";
            Console.WriteLine("{0} {1} {2}", a1, b1, c1);
            Console.WriteLine("\nPlease enter your name here: ");
            string name1 = Console.ReadLine();
            Console.WriteLine("Hello, " + name1);
            Console.ReadKey();
        }
    }
}
