using System;

namespace Section05_Loops
{
    public class Ex03_Break_Continue
    {
        public static void Exercise(){

            for(int i = 1; i <= 6; i++){
                
                if(i % 2 == 0){
                    break; // Stops the loop
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("break");


            for(int i = 1; i <= 6; i++){
                
                if(i % 2 == 0){
                    continue; // Skips the current iteration (will continue)
                }

                Console.WriteLine(i);
            }

            Console.WriteLine("continue");
        }
    }
}