using System;
using System.Collections;

namespace Hello{

    class HashTable
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();

            ht.Add(1, "Soham");
            ht.Add(2, "Aishik");
            ht.Add(3, "Kriti");
            ht.Add(4, "Ashish");

            foreach(int key in ht.Keys)
            {
                Console.WriteLine("Key: {0} Value: {1}", key, ht[key]);
            }

            Console.WriteLine("Add a new Name: ");

            string? newMember = Console.ReadLine();

            ht.Add(5, newMember);

            Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("The new Member is : {0}", ht[5]);

            Console.ResetColor();
        }
    }
}
