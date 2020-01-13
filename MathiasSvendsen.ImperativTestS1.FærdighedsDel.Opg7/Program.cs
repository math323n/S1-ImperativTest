using System;
using System.Linq;

namespace MathiasSvendsen.ImperativTestS1.FærdighedsDel.Opg7
{
    class Program
    {
        static void Main()
        {
            // Array
            double[] numberArray = new double[] { 44, 87, 12, 53, 38 };
            //Double for holding value
            double negativeSum = 0;

            for(int i = 0; i < numberArray.Length; i++)
            {
                // Print number
                Console.WriteLine(numberArray[i]);
                // Get negative sum
                negativeSum -= numberArray[i];
            }
            double sum = numberArray.Sum();
            //Print the results.
            Console.WriteLine("Alle tal udskrevet");
            Console.WriteLine("Den negative sum er: " + negativeSum);
            Console.WriteLine("Den totale sum er: " + sum);
        }
    }
}