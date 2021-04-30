using System;

namespace Section05_Loops
{
    public class Ex01_For
    {
        public static void ExBreak(string title){
            Console.Write("\n");
            Console.WriteLine("========== " + title + " ==========");
            Console.Write("\n");
        }

        public static void Main(string[] args){
            ExBreak("EX 01");

            for(int i=1; i <= 5; i++){
                Console.WriteLine(i);
            }

            ExBreak("EX 02");
            Ex02_While.Exercise();
            ExBreak("EX 03");
            Ex03_Break_Continue.Exercise();
            ExBreak("EX 04");
            Ex04_Foreach.Exercise();
        }
    }
}