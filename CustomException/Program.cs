using System;

namespace Hello{

    class MainClass
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()), b = Convert.ToInt32(Console.ReadLine());

            try
            {
                int c = a/b;
                Console.WriteLine(c);    
            }
            catch(Exception)
            {
                throw new Exception("YOU TRIED TO DIVIDE BY ZERO!");
            }
        }
    }
}
