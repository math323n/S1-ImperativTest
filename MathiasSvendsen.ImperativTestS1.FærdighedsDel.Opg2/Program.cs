using System;

namespace MathiasSvendsen.ImperativTestS1.FærdighedsDel.Opg2
{
    class Program
    {
        static void Main()
        {
            // Print text to console.
            Console.Write("Hej bruger. Indtast dit navn her: ");
            // Store the Users name in a string, and ask for input.
            string userName = Console.ReadLine();
            //Print the users name
            Console.WriteLine("Dit navn er " + userName);
        }
    }
}
