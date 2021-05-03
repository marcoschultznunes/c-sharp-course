using System;

namespace Section06_Array
{
    public class Ex01_Array
    {

        /*
            Arrays are a collection of elements of the same type, and they have 
            a fixed size. To have dynamic arrays which don't have that restriction,
            we'll later study Collections.
        */

        public static void ExBreak(string title){
            Console.Write("\n");
            Console.WriteLine("========== " + title + " ==========");
            Console.Write("\n");
        }

        public static void Main(string[] args){
            ExBreak("EX 01");

            // Declaring and initializing empty array
            int[] nums = new int[10]; 

            // Declaring, initializing and filling array
            string[] words = {
                "Oi", "Olá", "Hi", "Hello", "Guten Tag", "Ola"
            };

            // Changing the value of elements
            nums[4] = 26;
            words[2] = "Hallo";

            // Looping array with a for loop
            for(int i=0; i < words.Length; i++){
                Console.WriteLine(words[i]);
            }

            ExBreak("EX 02");
            Ex02_Matrix.Exercise();
        }
    }
}