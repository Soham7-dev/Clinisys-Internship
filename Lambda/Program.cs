using System;
using System.Collections;

namespace Hello{

    class Lambda{

        static void Main(string[] args)
        {
            List<int> list = new List<int>(){1, 2, 3, 4, 5, 6, 7, 8, 9, 10};

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("The Count of Even numbers is {0}\n", list.FindAll(a => (a%2 == 0)).Count());

            List<int> evenNumbers = list.FindAll(a => (a%2 == 0));

            Console.ForegroundColor = ConsoleColor.Magenta;

            foreach(int num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }

            Console.ResetColor();
        }
    }
}
