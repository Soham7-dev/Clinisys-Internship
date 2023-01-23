//FOREACH LOOP AND JUMP STATEMENT

using System;

namespace Hello{

    class ForeachJump{

        public static void Main(string[] args){

            int[] arr = new int[]{1, 2, 3, 4};

            foreach(int item in arr)
            {

                if(item == 3){
                    goto Bold;
                }
                Console.WriteLine(item);
            }

            Bold : Console.WriteLine("I am Bold");
        }
    }
}
