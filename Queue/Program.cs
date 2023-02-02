using System;

namespace Hello{

    class Queue
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            Console.WriteLine("TYPE 'exit' TO STOP GIVING INPUTS");

            while(true)
            {
                string? input = Console.ReadLine();

                if(input is null)
                {
                    continue;
                }
                else if(input.Equals("exit"))
                {
                    break;
                }
                else
                {
                    queue.Enqueue(Convert.ToInt32(input));
                }
            }

            Console.WriteLine("ITEMS IN THE QUEUE: ");

            while(queue.Count() > 0)
            {
                int item = queue.Dequeue();
                Console.WriteLine(item);
            }
        }
    }
}
