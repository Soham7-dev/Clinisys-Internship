using System;

namespace Hello{

    class MainClass
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Numerator: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Denominator: ");
            int b = Convert.ToInt32(Console.ReadLine());

            try
            {
                int c = a/b;
                Console.WriteLine("Result: " + c);    
            }
            catch(Exception)
            {
                throw new DivideByZeroException("YOU TRIED TO DIVIDE BY ZERO!");
            }
            finally
            {
                Console.WriteLine("try catch is finished");
            }

            int[] arr = new int[4]{1, 2, 3, 4};

            Console.WriteLine("WHICH ELEMENT OF THE ARRAY DO YOU WANT TO ACCESS:");

            int index = Convert.ToInt32(Console.ReadLine());

            if(index > 3)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                throw new IndexOutOfRangeException("You Tried to Access the Non-Existing Element");
            }
            else
            {
                Console.WriteLine("Element: " + arr[index]);
            }

            Console.ResetColor();

            Console.WriteLine("Enter a Value Between 0 and 255: ");

            try
            {
                byte num = Convert.ToByte(Console.ReadLine());
            }
            catch(Exception)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                throw new OverflowException("YOU SURPASSED THE RANGE OF NUMBERS!");
            }
            finally
            {
                Console.WriteLine("Everything is Perfect");
            }

            Console.ResetColor();
        }
    }
}
