using System;

namespace Hello{

    class MultiCastDelegate
    {
        public delegate void PrintLine(string str);

        public static void printHero(string name)
        {
            Console.WriteLine("My Favourite superhero is {0}", name);
        }

        public static void printTeam(string team)
        {
            Console.WriteLine("He is a member of {0}", team);
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Who is your Favourite SuperHero?");

            string? name = Console.ReadLine();

            Console.WriteLine("Which Team does he belong to?");

            string? team = Console.ReadLine();

            PrintLine pl = new PrintLine(printHero);

            pl += printTeam;

            Delegate[] delegateList = pl.GetInvocationList();

            Console.ForegroundColor = ConsoleColor.DarkYellow;

            delegateList[0].DynamicInvoke(name);

            delegateList[1].DynamicInvoke(team);

            Console.ResetColor();
        }
    }
}
