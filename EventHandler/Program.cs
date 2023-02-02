using System;

public delegate void MyHandler1(object sender, MyEventArgs e);
class A
{
    public void OnHandler1(object sender, MyEventArgs e)
    {
        Console.WriteLine("My name is Triggered : {0}", e.name);
    }
   
    public A(B b)
    {
        MyHandler1 d1 = new MyHandler1(OnHandler1);

        b.Event1 += d1;
    }
}
class B
{
    public event MyHandler1? Event1;
    public void FireEvent1(MyEventArgs e)
    {
        if (Event1 != null)
        {
            Event1(this, e);
        }
    }
    
}
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
