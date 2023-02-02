using System;

namespace Hello{

    class PartialClass{

        partial class Person
        {
            public int age;
            public string? name;

            public Person(int age,string name)
            {
                this.age = age;
                this.name = name;
            }
        }

        partial class Person
        {
            public void display()
            {
                Console.WriteLine("{0} is {1} years old", name, age);
            }

        }

        static void Main(string[] args)
        {
            Person p = new Person(21, "Soham");

            p.display();
        }
    }
}
