using System;

namespace Hello{

    class DynamicType
    {
        static void Main(string[] args)
        {
            dynamic a = "Lionel Messi";

            Console.WriteLine(a);

            a = 10;

            Console.WriteLine(a);
        }
    }
}
