using System;
using System.Linq;

namespace MathiasSvendsen.ImperativTestS1.FærdighedsDel.Opg4
{
    class Program
    {
        static void Main()
        {
            // Initialize the array for storing the 3 numbers.
            double[] userInputArray = new double[3];

            for(int i = 0; i < userInputArray.Length; i++)
            {
                Console.Write("Indtast et tal: ");
                // store userInput as string
                string userInput = Console.ReadLine();
                // TryParse userInput to double userNumber
                double.TryParse(userInput, out double userNumber);
                // Assign output to array
                userInputArray[i] = userNumber;
                Console.WriteLine(userInputArray[i]);
            }
            // Add numbers
            double sum = userInputArray.Sum();
            // Subtract numbers
            double subtracted = userInputArray[0] - userInputArray[1] - userInputArray[2];
            // Multiply numbers
            double multiplicated = userInputArray[0] * userInputArray[1] * userInputArray[2];
            // print the results to user.
            Console.WriteLine("Alle tre tal lagt sammen er: " + sum);
            Console.WriteLine("Alle tre tal trukket fra er: " + subtracted);
            Console.WriteLine("Alle tre tal multiplikeret er: " + multiplicated);
        }
    }
}