using System;

namespace _04.substrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "1 2 3 4 5 6 7"; //We want to remove intervals and , from the string;
            //to make the resutl itno string array, then we make new int array and we print it
            string[] numbersAsText =
                text.Split(' ');

            int[] numbers = new int[numbersAsText.Length];

            for (int i = 0; i < numbersAsText.Length; i++) //iterate and assign values
            {
                numbers[i] = int.Parse(numbersAsText[i]);
            }
            foreach (var item in numbers) //we iterate here again
            {
                Console.WriteLine(numbers[item]);
            }
            
              
        }
    }
}
