using System;

namespace Section02_Types
{
    public class Ex04_Math
    {
        
        public static void Exercise(){
            double n1 = 4.83912367;

            Console.WriteLine(n1);
            Console.WriteLine("Rounded: " + Math.Round(n1));
            Console.WriteLine("Floored: " + Math.Floor(n1));

            Console.WriteLine("Round(2): " + Math.Round(n1, 2));
            
            /* 
                Note: There is no method to floor to n decimal places, but you can use 
                the regular floor and some multiplication or create your own method.
            */
            Console.WriteLine("Floor(2): " + Math.Floor(n1 * 100) / 100);
            
            /* 
                In C#, to generate a random number we must instantiate an object of the
                Random class.
            */
            Random rand = new Random();
            int randNum = rand.Next(5, 21); // 5 to 20
            
            Console.WriteLine("Random Number(5-20): " + randNum);
        }
    }
}