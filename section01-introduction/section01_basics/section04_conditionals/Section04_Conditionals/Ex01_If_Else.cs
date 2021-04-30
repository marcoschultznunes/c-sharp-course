using System;

namespace Section04_Conditionals
{
    public class Ex01_If_Else
    {
        public static void ExBreak(string title){
            Console.Write("\n");
            Console.WriteLine("========== " + title + " ==========");
            Console.Write("\n");
        }

        public static void Main(string[] args){
            ExBreak("EX 01");

            Random rand = new Random();
            int n1 = rand.Next(-3, 4); 

            Console.WriteLine($"n1 = {n1}");

            if(n1 > 0){
                Console.WriteLine("Positive!");
            }
            else if(n1 < 0){
                Console.WriteLine("Negative!");
            }
            else{
                Console.WriteLine("Zero!");
            }

            ExBreak("EX 02");
            Ex02_Switch.Exercise();
        }
    }
}