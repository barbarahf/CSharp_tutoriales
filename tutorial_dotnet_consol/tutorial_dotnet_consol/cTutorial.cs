using System;

namespace tutorial_dotnet_consol
{
    public class cTutorial
    {
        static void Main03(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            /*int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());*/


            //   Console.WriteLine(num1 + num2);


            //Arrays
            int[] luckyNumbers = {4, 8, 15, 16, 23, 42};
            luckyNumbers[^1] = 15;
            Console.WriteLine(luckyNumbers[^1]);
        }
    }
}