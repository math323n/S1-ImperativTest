using System;
using System.Linq;

namespace MathiasSvendsen.ImperativTestS1.FærdighedsDel.Opg6
{
    class Program
    {
        static void Main()
        {
            int counter = 1;
            double[] waresArray = new double[2];

            for(int i = 0; i < waresArray.Length; i++)
            {
                Console.Write("Indtast prise på vare #"+counter+": ");
                // store userInput as string
                string userInput = Console.ReadLine();
                // TryParse userInput to double userNumber
                double.TryParse(userInput, out double userNumber);
                // Assign output to array
                waresArray[i] = userNumber;

                counter++;
            }
            // Discount price
            double discountPrice = (waresArray[0] * 0.90) + (waresArray[1] * 0.80);

            // Total price
            double totalPrice = waresArray.Sum();
            // Print results
            Console.WriteLine("totalprisen er: " + totalPrice + " discount pris er: " + discountPrice);
        }
    }
}
