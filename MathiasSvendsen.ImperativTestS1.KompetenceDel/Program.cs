using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace MathiasSvendsen.ImperativTestS1.KompetenceDel
{
    class Program
    {
        static void Main()
        {
            int counter = 1;
            List<double> wares = new List<double>();
            bool isDone = false;
            while(!isDone)
            {
                Console.WriteLine("Velkommen til menuen.\na. Indtast varer\nb. Udregn total\nc. Afslut");
                string userInput = Console.ReadLine();
                if(userInput == "a" || userInput == "1")
                {
                    bool enteredWares = false;
                    while(!enteredWares)
                    {
                        Console.WriteLine("Indtast prisen på en vare, eller skriv 'stop' for at stoppe, hvis du er færdig.");
                        string secondUserInput = Console.ReadLine();
                        bool success = double.TryParse(secondUserInput, out double warePrice);
                        if(success)
                        {
                            Console.WriteLine("Prisen på varen er " + warePrice);
                            wares.Add(warePrice);
                        }
                        else if(secondUserInput == "stop")
                        {
                            enteredWares = true;
                        }
                        else
                        {
                            Console.WriteLine("Fejl. Prøv igen");

                        }
                    }


                }

                else if(userInput == "b" || userInput == "2")
                {
                    bool calculated = false;
                    while(!calculated)
                    {
                        Console.WriteLine("Skriv 'ok for at fortsætte eller. 'stop' for at afslutte.\n");
                        string thirdUserInput = Console.ReadLine();
                        double sum = wares.Sum();

                        if(thirdUserInput == "stop")
                        {
                            break;
                        }
                        else if(thirdUserInput == "ok")
                        {
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine("De indtastede varer og deres priser og sum er: ");
                            foreach(var ware in wares)
                            {


                                Console.WriteLine("Vare #" + counter + " pris: " + ware);
                                counter++;
                            }
                            Console.WriteLine("Summen er: " + sum);
                            Console.WriteLine("-----------------------------------");
                        }
                    }

                }
                else if(userInput == "c" || userInput == "3")
                {
                    Console.WriteLine("Farvel");
                    foreach(object o in wares)
                    {
                        Console.WriteLine(o);
                    }
                }
                else
                {
                    Console.WriteLine("Fejl, forkert input.");
                    Thread.Sleep(2000);
                    Console.Clear();
                }
            }

        }
    }
}