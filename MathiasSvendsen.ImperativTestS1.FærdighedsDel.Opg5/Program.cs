using System;

namespace MathiasSvendsen.ImperativTestS1.FærdighedsDel.Opg5
{
    class Program
    {
        static void Main()
        {

            Console.Write("Indtast et beløb i kroner og ører: ");
            // store userInput as string
            string userInput = Console.ReadLine();
            // TryParse userInput to double userNumber
            double.TryParse(userInput, out double userNumber);

            // calcucate result; 25% of userNumber.
            double result = userNumber * 0.25;
            //Print the result to user.
            Console.WriteLine("25% af det er: {0:c}", result );
        }
    }
}