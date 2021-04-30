using System;

namespace Section02_Types
{
    public class Ex03_Casting_And_Conversions
    {
        public static void Exercise(){

            int n1 = 152;
            double d1 = n1; // Does not need explicit casting
            double d2 = 22.2; 
            int n2 = (int)(d2); // Explicit, floors the double


            /* Convert => Class with conversion methods (System namespace) */
            string s1 = "25";
            string s2;

            int n3 = Convert.ToInt32(s1);

            /* ToString */
            int n4 = 37;
            s2 = n4.ToString();

            Console.WriteLine("double d1 = " + d1);
            Console.WriteLine("int n2 = " + n2);
            Console.WriteLine("int n3 = " + n3);
            Console.WriteLine("string s2 = \"" + s2 + "\"");
        }
    }
}