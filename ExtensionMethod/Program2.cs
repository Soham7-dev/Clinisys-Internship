using System;

namespace Hello{

    static class NewClass
    {
        public static void printAge(this ExtensionMethod e, int age)
        {
            Console.WriteLine("My age is {0}", age);
        }
    }
}