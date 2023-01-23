//PARAMS MODIFIER

using System;

namespace Hello{

    class Params{

        static void Main(string[] args)
        {
            int sum = SumArray(1, 2, 3, 4, 5);

            Console.WriteLine("Sum of the array is {0}", sum);
        }

        static int SumArray(params int[] arr){

            int sum = 0;

            for(int i = 0; i < arr.Length; i++) sum += arr[i];

            return sum;
        }
    }

}
