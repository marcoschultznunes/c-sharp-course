using System;

namespace Section04_Conditionals
{
    public class Ex02_Switch
    {
        public static void Exercise(){
            Random rand = new Random();
            int month = rand.Next(13); // 0 - 12

            switch(month){
                case 1:
                    Console.WriteLine("1 - January!");
                    break;
                case 2:
                    Console.WriteLine("2 - February!");
                    break;
                case 3:
                    Console.WriteLine("3 - March!");
                    break;
                case 4:
                    Console.WriteLine("4 - April!");
                    break;
                case 5:
                    Console.WriteLine("5 - May!");
                    break;
                case 6:
                    Console.WriteLine("6 - June!");
                    break;
                case 7:
                    Console.WriteLine("7 - July!");
                    break;
                case 8:
                    Console.WriteLine("8 - August!");
                    break;
                case 9:
                    Console.WriteLine("9 - September!");
                    break;
                case 10:
                    Console.WriteLine("10 - October!");
                    break;
                case 11:
                    Console.WriteLine("11 - November!");
                    break;
                case 12:
                    Console.WriteLine("12 - December!");
                    break;
                default: // in a C# switch, the default must end with a break
                    Console.WriteLine("0 - Oh no, an error!");
                    break; 
            }
        }
    }
}