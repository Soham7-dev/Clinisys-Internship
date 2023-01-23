//1D ARRAY

using System;

namespace Hello{

    class ArrayOne{
        
        static void Main(string[] args)
        {
            Console.WriteLine("Input the Length of the Array: ");

            int n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input the elements of Array: ");

            int[] arr = new int[n];

            for(int i = 0; i < n; i++) arr[i] = Convert.ToInt32(Console.ReadLine());

            Array.Sort(arr);

            Console.ForegroundColor = ConsoleColor.Blue;

            Console.Write("Sorted Array: ");

            foreach(int i in arr) Console.Write(i + ", ");

            Console.ResetColor();
        }
    }
}
