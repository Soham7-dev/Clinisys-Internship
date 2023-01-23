//APPLICATION OF STRINGBUILDER

using System;
using System.Text;

namespace Hello{

    class Stringbuilder{

        static void Main(string[] args)
        {
            StringBuilder str = new StringBuilder("SOHAM");

            Console.WriteLine("Original String: {0}", str);

            str.Replace("S", "G");

            StringBuilder name = new StringBuilder();

            char[] arr = new char[]{'S', 'o', 'h', 'a', 'm'};

            for(int i = 0; i < arr.Length; i++)
            {
                name.Append(arr[i]);
            }

            Console.WriteLine("Updated String: {0}", str);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.WriteLine("Appended Name: {0}", name);

            Console.ResetColor();

        }
    }
}
