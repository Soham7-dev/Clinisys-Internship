//TRY CATCH EXCEPTION

using System;

namespace Hello{

    class TryCatch{

        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine()); 
            int b = Convert.ToInt32(Console.ReadLine());

            try{
                int c = a/b;
                Console.WriteLine(c);
            }
            catch(Exception e){
                Console.WriteLine(e.Message);
            }
        }
    }
}