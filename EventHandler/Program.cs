using System;

namespace Hello{
    public delegate void MyHandler1(object sender, MyEventArgs e);

    public class MyEventArgs : EventArgs
    {
        public string? name = "Soham";
    }
    public class Driver
    {
        public static void Main()
        {
            B b = new B();
            A a = new A(b);
            MyEventArgs e1 = new MyEventArgs();
            b.FireEvent1(e1);
        }
    }
}


