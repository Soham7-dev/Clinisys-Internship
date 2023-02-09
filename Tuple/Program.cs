using System;
using System.Linq;

namespace Hello{

    class Tuple
    {
        public delegate (int first, int second, int third) Square((int a, int b, int c) t);
        static void Main(string[] args)
        {
            Square sq = new Square(square);

            //INVOKING THE METHOD FOR SQUARE
            ValueTuple<int, int, int> ans = sq.Invoke((3,4,5));

            //USING LAMDA TO RETURN CUBE OF THE TUPLE AND INVOKING IT WHILE PRINTING
            Func<Tuple<int,int,int>, Tuple<int,int,int>> cube = (a) => (new Tuple<int,int,int>(a.Item1*a.Item1*a.Item1, a.Item2*a.Item2*a.Item2, a.Item3*a.Item3*a.Item3));

            //PRINTING SQUARE USING VALUE TUPLE
            Console.WriteLine("Square of Tuple : " + ans);

            //PRINTING CUBE USING NORMAL TUPLE
            Console.WriteLine("Cube of Tuple : " + cube(new Tuple<int,int,int>(3,4,5)));
        }

        public static (int first, int second, int third) square((int a, int b, int c) t)
        {
            int x = t.a, y = t.b, z = t.c;

            return (x*x, y*y, z*z);
        }
    }
}
