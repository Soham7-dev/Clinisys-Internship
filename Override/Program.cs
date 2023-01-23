//METHOD OVERRIDING PROGRAM

using System;

namespace Hello{

    class Car{

        public virtual void drive(){
            Console.WriteLine("I am driving a Car");
        }

    }

    class Audi : Car{

        public override void drive()
        {
            Console.WriteLine("I am driving a Audi");
        }
    }

    class Mercedes : Car{

        public override void drive()
        {
            Console.WriteLine("I am driving a Mercedes");
        }
    }

    class Override{

        public static void Main(string[] args){

            Car c = new Car();
            Audi a = new Audi();
            Mercedes m = new Mercedes();

            c.drive();
            a.drive();
            m.drive();

        }
    }
}
