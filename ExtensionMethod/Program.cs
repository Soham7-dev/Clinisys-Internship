using System;

namespace Hello{

    class ExtensionMethod
    {
        public void printName(string name)
        {
            Console.WriteLine("Hello, I am {0}", name);
        }

        static void Main(string[] args)
        {
            ExtensionMethod e = new ExtensionMethod();

            e.printName("Soham");
            e.printAge(21);
        }
    }
}
