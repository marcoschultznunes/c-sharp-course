using System;

namespace Section02_Types
{
    public class Ex06_Typeof
    {

    /*
        Note: When you use GetType(), it returns the class, so for instance,
        
        GetType of an int returns System.Int32,
        float => System.Single,
        double => System.Double,
        bool => System.Boolean,
        char => System.Char,
        string => System.String.

        typeof also returns the name like that, but accepts a type instead of a variable, 
        so for instance,
        
        typeof(int) returns System.Int32
    */

        private static void PrintType(object o1){
            if(o1.GetType() == typeof(int)){
                Console.WriteLine($"{o1} is an integer!\n");
            }
            if(o1.GetType() == typeof(float)){
                Console.WriteLine($"{o1} is a float!\n");
            }
            if(o1.GetType() == typeof(double)){
                Console.WriteLine($"{o1} is a double!\n");
            }
            if(o1.GetType() == typeof(bool)){
                Console.WriteLine($"{o1} is a boolean!\n");
            }
            if(o1.GetType() == typeof(string)){
                Console.WriteLine($"{o1} is a string!\n");
            }
            if(o1.GetType() == typeof(char)){
                Console.WriteLine($"{o1} is a char!\n");
            }
        }
        public static void Exercise(){
            string s1 = "Hello There";
            Boolean b1 = true;
            int i1 = 15;
            char c1 = 'E';

            PrintType(s1);
            PrintType(b1);
            PrintType(i1);
            PrintType(c1);
        }
    }
}