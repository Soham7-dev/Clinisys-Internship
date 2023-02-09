using System;
using System.Linq;

namespace Hello{

    class Tuple
    {
        public delegate ValueTuple<int, int, int> Square((int a, int b, int c) t);
        static void Main(string[] args)
        {
            Square sq = new Square(square);

            ValueTuple<int, int, int> ans = sq.Invoke((3,4,5));

            Func<(int, int, int), (int, int, int)> cube = (a) => (a.Item1*a.Item1*a.Item1, a.Item2*a.Item2*a.Item2, a.Item3*a.Item3*a.Item3);

            Console.WriteLine("Square of Tuple : " + ans);

            Console.WriteLine("Cube of Tuple : " + cube((3,4,5)));
        }

        public static ValueTuple<int, int, int> square((int a, int b, int c) t)
        {
            int x = t.a, y = t.b, z = t.c;

            return new ValueTuple<int, int, int>(x*x, y*y, z*z);
        }
    }
}
