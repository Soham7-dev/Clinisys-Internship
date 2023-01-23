using System;

namespace CMS.Application{

    public class Encapsulation{

        private int number;
        private String? name;

        public String Name
        {
            get{
                return name;
            }
            set{
                name = value;
            }
        }

        public int Number{
            get{
                return number;
            }
            set{
                number = value;
            }
        }
    }

    public class Hello{

        public static void Main(string[] args){

            Encapsulation e = new Encapsulation();

            e.Number = 10;
            e.Name = "Lionel Messi";

            Console.WriteLine("Name: " + e.Name);
            Console.WriteLine("Number: " + e.Number);
        }
    }
}
