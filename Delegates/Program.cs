using System;

namespace Hello{

    class Delegates{

        public delegate void PrintName(string name);

        public static void printName(string name)
        {
            Console.WriteLine("Hello, I am {0}", name);
        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Write Your Name: ");

            string? input = Console.ReadLine();

            PrintName pName = new PrintName(printName);
            PrintName pNameLambda = new PrintName((input) => {Console.WriteLine("Hello, I am LAMBDA {0}", input);});

            if(input == null || input == "")
            {
                Console.WriteLine("Input can not be null");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                pName.Invoke(input);
                Console.ForegroundColor = ConsoleColor.Green;
                pNameLambda.Invoke(input);
                Console.ResetColor();
            }
        }

    }
}
