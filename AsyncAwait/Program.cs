using System;

namespace Hello{

    class AsyncAwait
    {
        static void Main(string[] args)
        {
            var v = asyncMethod();

            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("Soham Das");
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.ReadKey();

            Console.ResetColor();
        }
        public static async Task asyncMethod()
        {
            await Task.Run(() => {

                for(int i = 1; i <= 10; i++)
                {
                    Task.Delay(2000).Wait();

                    Console.WriteLine("\nHacking NASA");
                }

            });
        }
    }
}
