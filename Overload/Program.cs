// METHOD OVERLOADING

using System;

namespace Hello{

    class Overload{

        public static int area(int a, int b)
        {
            return a*b;
        }

        public static float area(float r)
        {
            return (3.14F)*r*r;
        }

        public static void Main(string[] args)
        {
            int a = area(3,4);
            float b = area(5.0F);

            Console.WriteLine("Area of Rectangle is : " + a);
            Console.WriteLine("Area of Circle is : " + b);
        }
    }
}
