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

            Console.WriteLine(ans);
        }

        public static Tuple<int, int, int> square((int a, int b, int c) t)
        {
            int a = t.Item1, b = t.Item2, c = t.Item3;

            return new Tuple<int, int, int>(a*a,b*b,c*c);
        }
    }
}
