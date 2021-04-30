using System;

namespace Section02_Types
{
    class Program
    {
        /*
            C# is statically typed.
        */
        
        private static void ExBreak(string title){
            Console.Write("\n");
            Console.WriteLine("========== " + title + " ==========");
            Console.Write("\n");
        }
        static void Main(string[] args)
        {
            int n1 = 10;
            Int32 n2 = 24; // also integer
            float f1 = 15.6f;
            double d1 = 22.4;
            string s1 = "Oi";
            char c1 = 'A'; // Has to be single quote

            object o1 = 10; // object is the generic type from which all derive.
            o1 = "Hello";
            o1 = false;
            
            ExBreak("EX 01");
            Console.WriteLine("int n1 = " + n1);
            Console.WriteLine("Int32 (also integer) n2 = " + n2);
            Console.WriteLine("float f1 = " + f1);
            Console.WriteLine("double d1 = " + d1);
            Console.WriteLine("string s1 = \"" + s1 + "\"");
            Console.WriteLine("char c1 = \'" + c1 + "\'");
            Console.WriteLine("object o1 = " + o1);

            ExBreak("EX 02");
            Ex02_Const.Exercise();
            ExBreak("EX 03");
            Ex03_Casting_And_Conversions.Exercise();
            ExBreak("EX 04");
            Ex04_Math.Exercise();
            ExBreak("EX 05");
            Ex05_String.Exercise();
            ExBreak("EX 06");
            Ex06_Typeof.Exercise();
            
            // Note: Console.Write => no line break at the end
        }
    }
}
