using System;

namespace Section02_Types
{
    public class Ex05_String
    {
        public static void Exercise(){
            string s1 = " Oi Mate ";
            s1 = s1.Trim(); // Trim => returns

            Console.WriteLine($"string s1 = {s1}\n"); // $"{var}" => string interpolation
            Console.WriteLine($"Length: {s1.Length}");
            Console.WriteLine($"ToUpper: {s1.ToUpper()}");
            Console.WriteLine($"ToLower: {s1.ToLower()}");

            // Replace => case sensitive and replaces all occurences
            s1 = s1.Replace('e', 'a'); 

            Console.WriteLine($"Replace('e', 'a'): {s1}");

            // Substring(start, length)
            string s2 = s1.Substring(3, 3); // 3 to 5

            Console.WriteLine($"Substring(3, 5): {s2}");
        }
    }
}