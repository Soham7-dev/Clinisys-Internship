using System;

namespace Hello
{

    interface IName
    {

        string printName(string? name);
    }

    interface IAge
    {

        int getAge(int age);
    }

    class Interface : IName, IAge
    {

        public string printName(string? name)
        {
            if(name == null)
                return "String can not be Null";
            else
                return name;
        }

        public int getAge(int age)
        {
            return age;
        }

        static void Main(string[] args)
        {
            Interface I = new Interface();

            string name = I.printName("Barry Allen");
            int age = I.getAge(29);

            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("My name is {0} and I am {1} years old", name,age);

            Console.ResetColor();
        }

    }
}
