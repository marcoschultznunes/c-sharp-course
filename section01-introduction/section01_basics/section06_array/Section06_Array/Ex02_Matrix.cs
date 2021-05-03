using System;

namespace Section06_Array
{
    public class Ex02_Matrix
    {
        public static void Exercise(){
            int[,] nums = new int[4, 8]; // 4 lines and 8 columns

            /* 
                To loop the matrix we use the GetLength method, which accepts the 
                dimension of the array to get the length from.
            */
            for(int l = 0; l < nums.GetLength(0); l++){
                for(int c = 0; c < nums.GetLength(1); c++){
                    nums[l, c] = (int)Math.Pow(2, l) + c * l;
                }
            }

            // Printing the array
            for(int l = 0; l < nums.GetLength(0); l++){
                for(int c = 0; c < nums.GetLength(1); c++){
                    Console.Write(nums[l, c] + " ");

                    if(c == nums.GetLength(1) - 1){
                        Console.Write("\n");
                    }
                }
            }
        }
    }
}