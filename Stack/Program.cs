using System.Collections.Generic;

namespace Hello{

    class Stack
    {
        static void Main(string[] args)
        {
            Stack<int> stack = new Stack<int>();

            Console.WriteLine("Enter the Digits:");

            while(true)
            {
                string? str = Console.ReadLine();

                if(str is null)
                {
                    continue;
                }
                else if(str.Equals("exit"))
                {
                    break;
                }
                else
                {
                    stack.Push(Convert.ToInt32(str));
                }

            }

            Console.WriteLine("Elements of The Stack By Order:");

            while(stack.Count() > 0)
            {
                int item = stack.Pop();
                Console.WriteLine(item);
            }
        }
    }
}
