using System;

namespace Hello{

    class JaggedArray{

        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of Rows: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int[][] arr = new int[n][];

            for(int i = 0; i < n; i++)
            {
                
                Console.WriteLine("Enter no of Columns in {0}th Row", (i+1));

                int m = Convert.ToInt32(Console.ReadLine());

                arr[i] = new int[m];

                Console.WriteLine("Enter the Digits: ");

                for(int j = 0; j < m; j++)
                {
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                    
            }

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\nThe Following Jagged Array is: \n");

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write(arr[i][j] + " ");
                }
                Console.WriteLine();
            }

            Console.ResetColor();
        }
    }
}
