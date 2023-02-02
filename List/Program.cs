
using System;
using System.Collections.Generic;

namespace Hello{

    class List
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nIF YOU ARE DONE WITH GIVING INPUTS THEN ENTER 'exit'\n");

            Console.ResetColor();

            // int num;

            while(true)
            {
                var input = Console.ReadLine();
                
                if(input == null)
                {
                    continue;
                }
                else if(input.Equals("exit"))
                {
                    break;
                }
                else
                {
                    list.Add(Convert.ToInt32(input));
                }
            }

            Console.WriteLine("\nHere is your List of Numbers:\n");

            Console.WriteLine("[" + string.Join(",", list.ToArray()) + "]");
        }
    }
}
