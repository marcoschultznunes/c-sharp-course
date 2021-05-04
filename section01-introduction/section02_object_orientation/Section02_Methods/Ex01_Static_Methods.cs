using System;

namespace Section02_Methods
{
    public class Ex01_Static_Methods
    {
        private string Name;
        private string Occupation;

        public Ex01_Static_Methods(string name, string occupation){
            Name = name;
            Occupation = occupation;
        }

        /* Non-static method => must be accessed through an object */
        public void Greet(){
            Console.WriteLine($"Hello! I'm {this.Name}, and i am a {this.Occupation}");
        }

        /* Static method => accessed through the class */
        public static void Exercise(){
            Ex01_Static_Methods e1 = new Ex01_Static_Methods("Marcelo", "Teacher");
            e1.Greet(); // Non-static method being accessed through an object  
        }

        public static void Main(string[] args){
            Breaks.ExBreak("Ex 01");

            Exercise(); // Static method being called

            Breaks.ExBreak("Ex 02");
            Ex02_Overloading.Exercise();
        }
    }
}