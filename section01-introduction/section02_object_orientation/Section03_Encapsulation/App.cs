using System;

namespace Section03_Encapsulation
{
    public class App
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("\nEX 01\n");

            Ex01_Access_Modifiers e1 = new Ex01_Access_Modifiers();
            Console.WriteLine("Ex01_Access_Modifiers.PI = " + Ex01_Access_Modifiers.PI);
            Console.WriteLine("Ex01_Access_Modifiers.Count = " + Ex01_Access_Modifiers.Count);
            
            /* 
                All other attributes cannot be accessed because they are either protected
                or private 
            */

            Console.WriteLine("\nEX 02\n");

            Ex02_Encapsulation e2 = new Ex02_Encapsulation("Ernesto", "Gonzalez", 1989);
            e2.SetLastName("Dias");
            e2.SetYearOfBirth(1988);

            Console.WriteLine("e2.GetFirstName() => " + e2.GetFirstName());
            Console.WriteLine("e2.GetLastName() => " + e2.GetLastName());
            Console.WriteLine("e2.GetYearOfBirth() => " + e2.GetYearOfBirth());
            Console.WriteLine("e2.GetId() => " + e2.GetId());
        }
    }
}