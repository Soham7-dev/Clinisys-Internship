using System;
using System.Linq;

namespace Hello{

    class Tuple
    {
        public delegate Tuple<int, int, int> Square((int a, int b, int c) t);
        static void Main(string[] args)
        {
            Square sq = new Square(square);

            Tuple<int, int, int> ans = sq.Invoke((3,4,5));

            Func<(int, int, int), (int, int, int)> cube = (a) => (a.Item1*a.Item1*a.Item1, a.Item2*a.Item2*a.Item2, a.Item3*a.Item3*a.Item3);

            Console.WriteLine("Square of Tuple : " + ans);

            Console.WriteLine("Cube of Tuple : " + cube((3,4,5)));
        }

        public static Tuple<int, int, int> square((int a, int b, int c) t)
        {
            int a = t.Item1, b = t.Item2, c = t.Item3;

            return new Tuple<int, int, int>(a*a,b*b,c*c);
        }
    }
}
