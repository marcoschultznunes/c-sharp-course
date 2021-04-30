using System;

namespace Section05_Loops
{
    public class Ex02_While
    {
        public static void Exercise(){
            int n = 2;
            int exp = 0;

            // Will not print, as 2 ^ 0 = 1, so the loop condition will immediately fail
            while(Math.Pow(n, exp) >= 2){ 
                Console.WriteLine(Math.Pow(n, exp));
                exp++;

                if(Math.Pow(n, exp) >= 32){
                    break;
                }
            }

            // Will print, as "do" always does the first iteration
            do{ 
                Console.WriteLine(Math.Pow(n, exp));
                exp++;

                if(Math.Pow(n, exp) >= 32){
                    break;
                }
            } while(Math.Pow(n, exp) >= 2);
        }
    }
}