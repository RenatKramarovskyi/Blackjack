using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class ReadMethods
    {
        public static int ReadInteger(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {

            do
            {
                Console.Write(prompt);
                string userInput;
                bool yes = int.TryParse(userInput = Console.ReadLine(), out int userNumber);
                if (yes == true)
                {
                    if (userNumber <= max && userNumber >= min)
                    {
                        return userNumber;
                    } 
                    else
                    {
                        Console.WriteLine("Please enter a number between " + min + " and " + max);
                    } 
                }
                else
                {
                    Console.WriteLine("Wrong input, please try again . . .");
                } 
            } while (true); 
        } 

        public static void ReadChoice(string prompt, string[] options, out int selection)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(options[i]);
            } 
            Console.WriteLine(); 
            selection = ReadInteger(prompt, 1, options.Length); 
        } 



    } 

}