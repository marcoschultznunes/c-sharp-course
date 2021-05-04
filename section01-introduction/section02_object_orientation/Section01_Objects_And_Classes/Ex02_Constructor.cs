using System;

namespace Section01_Objects_And_Classes
{
    public class Ex02_Constructor
    {
        /* Properties */
        private string FirstName;
        private string LastName;
        private int Age;

        /* Constructor => sets the properties values when an object is created */
        public Ex02_Constructor(string firstName, string lastName, int age){
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        /* 
            A class can have multiple constructors, depending on which properties to
            initialize. In this case, just the first name.
        */
        public Ex02_Constructor(string firstName){
            FirstName = firstName;
        }

        /* Methods */
        public static void Exercise(){
            Ex02_Constructor e1 = new Ex02_Constructor("John", "Cena", 44);

            Console.WriteLine($"First name: {e1.FirstName}");
            Console.WriteLine($"Last name: {e1.LastName}");
            Console.WriteLine($"Age: {e1.Age}");
        }
    }
}