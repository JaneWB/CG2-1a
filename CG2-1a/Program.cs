using System;

namespace CG2_1a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is you name?");
            Console.WriteLine("Type your first name");
            string myFirstName = Console.ReadLine();

            Console.WriteLine("Type your last name");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName);
            Console.ReadLine();
        }
    }
}
