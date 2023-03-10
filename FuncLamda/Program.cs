using System;

namespace Hello{

    class FuncLamda
    {
        static void Main(string[] args)
        {
            //Expression Lambda
            Func<int, int, int> add = (a,b) => (a+b);

            int c = add(10,20);

            Console.WriteLine("Sum of two Numbers {0}", c);

            //Statement Lambda
            Action<int, int> add2 = ( a, b) => {int c = a+b; Console.WriteLine("Sum of Two Numbers: {0}", c);};

            add2(40,50);
        }
    }
}
