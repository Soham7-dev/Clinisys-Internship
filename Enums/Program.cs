//IMPLEMENTATION OF ENUMS

using System;

namespace Hello{

    class Enums{

        enum JusticeLeague{

            Batman,
            Superman,
            WonderWoman,
            Flash,
            Aquaman,
            Cyborg,
            GreenLantern,
            Shazam,
            MartianManhunter,
            Hawkgirl,
        }

        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            
            Console.WriteLine("\nTHESE ARE ALL THE JUSTICE LEAGUE MEMBERS: \n");

            Console.ForegroundColor = ConsoleColor.Yellow;

            for(int i = 0; i < 10; i++)
            {
                Console.Write((JusticeLeague)i + ", ");
            }

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("\n\nTHESE ARE ALL THEIR TRAITS: \n");

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine(JusticeLeague.Batman + " is the Smartest of the League\n");
            Console.WriteLine(JusticeLeague.Superman + " is the Protector of Earth\n");
            Console.WriteLine(JusticeLeague.WonderWoman + " is the Princess of Themyscira\n");
            Console.WriteLine(JusticeLeague.Flash + " is the Fastest Man Alive\n");
            Console.WriteLine(JusticeLeague.Aquaman + " is the King of Ocean\n");
            Console.WriteLine(JusticeLeague.GreenLantern + " has the most Powerful weapon in the Universe\n");
            Console.WriteLine(JusticeLeague.Shazam + " has the power of Magic\n");
            Console.WriteLine(JusticeLeague.MartianManhunter + " is capable of ShapeShifting\n");
            Console.WriteLine(JusticeLeague.Hawkgirl + " has Hysterical Strength\n");

            Console.ResetColor();
        }
    }
}
