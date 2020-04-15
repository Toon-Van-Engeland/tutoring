using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
#if RELEASE
            #region Oplossing
            Random random = new Random();
            int randomIntBetween1And100 = random.Next(100);
            Console.WriteLine("Raad het getal tussen 1 en 100.");
            int guess = 0;
            do
            {
                string input = Console.ReadLine();
                if (input == null)
                {
                    Console.WriteLine("Gelieve iets in te vullen");
                }
                else
                {
                     guess = Int32.Parse(input);
                     if (guess < randomIntBetween1And100)
                     {
                         Console.WriteLine($"Het getal is groter dan {guess}");
                     }
                     else if (guess != randomIntBetween1And100)
                     {
                        Console.WriteLine($"Het getal is kleiner dan {guess}");
                     }
                }
            } while (guess != randomIntBetween1And100);

            Console.WriteLine($"Correct het getal was {randomIntBetween1And100}");
            #endregion
#else
            Console.WriteLine("Raad het getal tussen 1 en 100");

            //TODO Maak een willekeurig getal tussen 1 en 100 aan

            #region Tip 1

            //Maak gebruik van de klasse Random

            #endregion

            #region Tip 2

            //Maak gebruik van de .Next() functie
            //Hier kan je ook een maximum getal inzetten

            #endregion

            //TODO lees een getal in door de Console

            #region Tip 1

            //Door Console.ReadLine kan je volgende regel inlezen, je krijgt een string terug

            #endregion

            #region Tip 2

            //Je kan dan met Int32.Parse deze string omzetten naar een getal

            #endregion

            //TODO maak nu duidelijk dat het te raden getal groter of kleiner is...

            #region Tip 1

            //Maak hier gebruik van een if-lus

            #endregion

            #region Tip 2

            //Je gaat eerst moeten kijken of het getal groter is en daarna of het kleiner is

            #endregion

            #region Tip 3

            //Met Console.Writeline kan je iets weergeven in de Console

            #endregion

            //TODO stop het raden van het getal nu in een lus, deze blijft lopen zolang het getal niet geraden is

            #region Tip 1

            //Je kan hier best gebruik maken van een while-lus, (do-while gaat ook)

            #endregion

            //TODO Maak nu een boodschap aan de gebruiker als hij het getal geraden heeft

#endif
            Console.Read();
        }
    }
}
