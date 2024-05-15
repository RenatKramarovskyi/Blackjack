using System;

namespace ClassLibrary
{
    public static class ReadMethods
    {
        public static int ReadInteger(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            do
            {
                Console.Write(prompt);
                string userInput = Console.ReadLine()!;
                bool isNumber = int.TryParse(userInput, out var userNumber);

                if (isNumber && userNumber >= min && userNumber <= max)
                {
                    return userNumber;
                }

                Console.WriteLine(isNumber ? $"Please enter a number between {min} and {max}." : "Wrong input, please try again . . .");
            } while (true);
        }

        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            foreach (string option in options)
            {
                Console.WriteLine(option);
            }

            Console.WriteLine();
            selection = ReadInteger(prompt, 1, options.Length);
        }
    }
}