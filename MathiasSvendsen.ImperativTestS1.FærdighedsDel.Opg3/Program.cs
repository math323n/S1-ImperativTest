using System;

namespace MathiasSvendsen.ImperativTestS1.FærdighedsDel.Opg3
{
    class Program
    {
        static void Main()
        {
            
            // Infinite while loop.
            while(true)
            {
                // Ask for input in the interval 1 to 10.
                Console.Write("Indtast et tal, i intervallet fra 1 til 10: ");
                // store userInput as string
                string userInput = Console.ReadLine();
                // TryParse userInput to int userNumber
                int.TryParse(userInput, out int userNumber);
                // if userNumber under 1. Or under 10.
                if(userNumber < 1 || userNumber > 10)
                {
                    // Let the user know the input is wrong.
                    Console.WriteLine("Fejl, tal uden for intervallet.");
                }
                // Else if over or equal to 1. AND less than or equal to 10.
                else if(userNumber >= 1 && userNumber <= 10)
                {
                    if(userNumber > 5)
                    {
                        // If userNumber was 5.
                        Console.WriteLine("Dit tal er over 5.");
                    }
                    else if(userNumber < 5)
                    {
                        // If under 5.
                        Console.WriteLine("Dit tal er under 5.");
                    }
                    else if(userNumber == 5)
                    {
                        // If over 5.
                        Console.WriteLine("Dit tal er 5.");
                    }
                }
            }
        }
    }
}