using System;

namespace Hello{

    class Program
    {
        static void Main(string[] args)
        {
            Publisher pb = new Publisher();
            Subscriber sb = new Subscriber();

            pb.eventSum += sb.AddSum;

            int c = pb.RaiseEvent(5,6);

            Console.WriteLine("Sum of two Numbers: {0}" , c);
        }
    }
}
