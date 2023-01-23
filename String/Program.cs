using System;

namespace Hello{

    class String{

        static void Main(string[] args)
        {
            string a = "Hello World";
            string b = (string)a.Clone();
            Console.WriteLine("Copied String is {0}", b);

            string firstName = "Soham";
            string lastName = " Das";

            string fullName = string.Concat(firstName, lastName);

            Console.WriteLine("My Name is {0}", fullName);
        }
    }
}
