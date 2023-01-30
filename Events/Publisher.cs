using System;

namespace Hello{

    public delegate int PrintSum(int a, int b);

    class Publisher
    {
        public event PrintSum ?eventSum;

        public int RaiseEvent(int a, int b)
        {
            if(this.eventSum != null)
                return this.eventSum(a,b);
            else
                return 0;
        }
    }
}