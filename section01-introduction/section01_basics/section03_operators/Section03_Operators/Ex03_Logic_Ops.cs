using System;

namespace Section03_Operators
{
    public class Ex03_Logic_Ops
    {
        public static void Exercise(){
            int a = 10;
            int b = 5;
            float c = 10;
            bool d = false;

            Console.WriteLine("int a = 10");
            Console.WriteLine("int b = 5");
            Console.WriteLine("float c = 10");
            Console.WriteLine("boolean d = false \n");

            /* NOT ! */
            Console.WriteLine($"!d : {!d}\n");

            /* OR || */
            Console.WriteLine($"a == b or a == c : {a==b || a==c}");

            /* AND && */
            Console.WriteLine($"a == b and a == c : {a==b && a==c}");
        }
    }
}