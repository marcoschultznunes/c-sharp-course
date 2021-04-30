using System;

namespace Section03_Operators
{
    public class Ex02_Relational_Ops
    {
        public static void Exercise(){
            int a = 10;
            int b = 5;
            float c = 10;

            Console.WriteLine("int a = 10");
            Console.WriteLine("int b = 5");
            Console.WriteLine("float c = 10 \n");

            /* Relational ops */
            Console.WriteLine($"a > b : {a > b}");
            Console.WriteLine($"a < b : {a < b}");
            Console.WriteLine($"a > c : {a > c}");
            Console.WriteLine($"a >= c : {a >= c}");
            Console.WriteLine($"a == c : {a == c}");
            Console.WriteLine($"a != c : {a != c}");
        }
    }
}