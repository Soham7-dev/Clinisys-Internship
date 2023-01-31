using System;
using System.Dynamic;

namespace Hello{

    class Expando
    {
        static void Main(string[] args)
        {
            dynamic exp = new ExpandoObject();

            exp.fname = "Soham";
            exp.lname = "Das";
            exp.age = 21;
            exp.print = exp.fname + " " + exp.lname + String.Format(" is {0} years Young", exp.age);

            foreach(var property in (IDictionary<String, Object>)exp)
            {
                Console.WriteLine(property.Key + " : " + property.Value);
            }
        }
    }
}
