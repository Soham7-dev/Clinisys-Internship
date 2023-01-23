// 2D ARRAY

using System;

namespace Hello{

    class ArrayTwo{

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of rows: ");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter number of columns: ");

            int m = Convert.ToInt32(Console.ReadLine());

            int[,] arr = new int[n,m];

            Console.WriteLine("Enter Digits: ");

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    arr[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Here is The Matrix: ");

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    Console.Write(arr[i,j] + " ");
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
