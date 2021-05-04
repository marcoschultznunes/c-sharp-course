using System;

namespace Section01_Objects_And_Classes
{
    class Ex01_Object
    {
        static void Main(string[] args)
        {   
            Breaks.ExBreak("Ex 01");

            // Instantiating an object of the class
            Ex01_Object p1 = new Ex01_Object();

            Console.WriteLine(p1.GetType()); // Prints [namespace].[class]

            Breaks.ExBreak("Ex02");
            Ex02_Constructor.Exercise();
        }
    }
}
