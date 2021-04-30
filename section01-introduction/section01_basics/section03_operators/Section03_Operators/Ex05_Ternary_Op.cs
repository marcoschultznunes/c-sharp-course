using System;

namespace Section03_Operators
{
    public class Ex05_Ternary_Op
    {
        public static void Exercise(){
            Random rand = new Random();
            int n1 = rand.Next(15); // 0 - 15

            string oddOrEven = n1 % 2 == 0 ? "even" : "odd"; // Ternary operator

            Console.WriteLine($"n1 = {n1}");
            Console.WriteLine($"n1 is {oddOrEven}!");
        }
    }
}