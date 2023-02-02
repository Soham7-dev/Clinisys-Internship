using System;
using System.Collections.Generic;

namespace Hello{

    class Dict
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();

            dict.Add("Batman", "Smartest");
            dict.Add("SuperMan", "Strongest");
            dict.Add("WonderWoman", "Oldest");
            dict.Add("Flash", "Fastest");

            foreach(string name in dict.Keys)
            {
                if(name.Equals("Flash"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }

                Console.WriteLine("{0} is {1}", name, dict[name]);
            }

            Console.ResetColor();

            Console.WriteLine("Enter a new Justice League Member: ");

            string? newMember = Console.ReadLine();

            Console.WriteLine("Enter his/her Characteristics: ");

            string? charac = Console.ReadLine();

            if(newMember is null || charac is null)
            {
                throw new Exception("You Entered Null Value!");
            }
            else
            {
                dict.Add(newMember, charac);
            }

            foreach(string name in dict.Keys)
            {
                if(name.Equals("Flash"))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else
                {
                    Console.ResetColor();
                }

                Console.WriteLine("{0} is {1}", name, dict[name]);
            }

            Console.ResetColor();
        }
    }
}
