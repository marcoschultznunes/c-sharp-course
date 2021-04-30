using System;

namespace Section03_Operators
{
    public class Ex01_Assignment_Arithmetic_Ops
    {
        public static void ExBreak(string title){
            Console.Write("\n");
            Console.WriteLine("========== " + title + " ==========");
            Console.Write("\n");
        }

        public static void Main(string[] args){
            ExBreak("EX 01");

            int a;
            int b = 10;

            /* Assignment ops */
            a = 0;
            a += 10; // 10
            a -= 5; // 5
            a *= 100;  // 500
            a /= 20; // 25
            a %= 7; // 4

            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a = {a}");
            
            /* Arithimetic ops */
            Console.WriteLine($"a + b = {a+b}"); // a+b
            Console.WriteLine($"a - b = {a-b}"); // a-b
            Console.WriteLine($"a * b = {a*b}"); // a*b
            Console.WriteLine($"a / b = " + (float)(a)/(float)(b)); // a/b
            Console.WriteLine($"b pow a = {Math.Pow(b, a)}"); // a pow b
            Console.WriteLine($"b %% a = {b%a}"); // b%a

            ExBreak("EX 02");
            Ex02_Relational_Ops.Exercise();
            ExBreak("EX 03");
            Ex03_Logic_Ops.Exercise();
            ExBreak("EX 04");
            Ex04_Unary_Ops.Exercise();
            ExBreak("EX 05");
            Ex05_Ternary_Op.Exercise();
        }
    }
}