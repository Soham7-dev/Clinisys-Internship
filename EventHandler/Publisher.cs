//PUBLISHER CLASS
namespace Hello{

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
}