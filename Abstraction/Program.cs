using System;

namespace Hello{

    public class Abstraction{

        abstract class Animal{

            public abstract void sound();

            public abstract void move();

        }

        class Dog : Animal{

            public override void sound()
            {
                Console.WriteLine("Dog Barks");
            }

            public override void move()
            {
                Console.WriteLine("Dog runs");
            }
        }

        public static void Main(string[] args){

            Dog d = new Dog();

            d.sound();
            d.move();
        }
    }
}
