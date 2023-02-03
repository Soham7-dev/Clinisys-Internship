
namespace Hello{
    //SUBSCRIBER CLASS
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
}
