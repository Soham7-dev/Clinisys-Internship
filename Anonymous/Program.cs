using System;

namespace Hello{

    class Anonymous
    {
        static void Main(string[] args)
        {
            var anonymous = new { Name = "Flash", TopSpeed = "299,792,458 m/s"};
            var newAnonymous = anonymous with { TopSpeed = "Greater than Speed of Light"};

            Console.WriteLine(anonymous.Name + " " + anonymous.TopSpeed + " " + newAnonymous.TopSpeed);
        }
    }
}
