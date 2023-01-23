using System;

namespace Hello{

    class StaticClass{

        static class Soham
        {
            public static string name = "Soham Das";
            public static int age = 21;
            public static bool isHappy = true;

            public static void display()
            {
                Console.WriteLine("\nSoham's favourite superhero is Flash!");
            }
            
        }

        static void Main(string[] args)
        {
            string name = Soham.name;

            int age = Soham.age;

            bool isHappy = Soham.isHappy;

            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("isHappy: {0}", isHappy);

            Console.ForegroundColor = ConsoleColor.Yellow;
            Soham.display();
            Console.ResetColor();
        }
    }
}
