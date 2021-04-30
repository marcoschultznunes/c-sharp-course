using System;

namespace Section05_Loops
{
    public class Ex04_Foreach
    {
        public static void Exercise(){
            int[] nums = {10, 20, 30, 40};

            foreach(int n in nums){ // Equivalent to Java for(int n: nums)
                Console.WriteLine(n);
            }
        }
    }
}