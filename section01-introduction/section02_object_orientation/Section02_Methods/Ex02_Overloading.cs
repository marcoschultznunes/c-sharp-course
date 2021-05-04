using System;

namespace Section02_Methods
{
    public class Ex02_Overloading
    {
        /*
            Overloading is a form of polymorphism which consists in declaring a method
            more than once in a class, but using different parameters.
        */
        public static int sum(int n1, int n2){
            return n1 + n2;
        }

        public static double sum(double n1, int n2){
            return n1 + n2;
        }

        public static double sum(int n1, double n2){
            return n1 + n2;
        }

        public static double sum(double n1, double n2){
            return n1 + n2;
        }

        public static void Exercise(){
            Console.WriteLine($"10 + 5 = {sum(10, 5)}");
            Console.WriteLine($"5.5 + 6 = {sum(5.5, 6)}");
            Console.WriteLine($"7 + 12.3 = {sum(7, 12.3)}");
            Console.WriteLine($"2.8 + 3.2 = {sum(2.8, 3.2)}");
        }
    }
}