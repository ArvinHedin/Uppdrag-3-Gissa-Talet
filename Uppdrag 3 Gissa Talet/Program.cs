using System;

namespace GissaTalet
{
    class Mainclass
    {
        public static void Main(string[] args)
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 101);
            int numberOfGuesses = 0;
            int guess;


            Console.WriteLine("Välkommen till spelet: Gissa Talet!");
            Console.WriteLine("Tryck på Enter för att börja spela");
            Console.ReadLine();
            Console.WriteLine("Jag har valt ett tal mellan 1 och 100 som du ska få gissa på.");
            
            do
            {
                Console.WriteLine("Gissa på talet!");
                guess = Convert.ToInt32(Console.ReadLine());
                numberOfGuesses += 1;

                if(guess < 1)
                {
                    Console.WriteLine("Du mmåste gissa på ett tal mellan 1 och 100!");
                }

                else if (guess > 100)
                {
                    Console.WriteLine("Du mmåste gissa på ett tal mellan 1 och 100!");
                }

                else if (guess < random)
                {
                    if (guess > random - 6)
                    {
                        Console.WriteLine("Du gissade tyvärr för lågt, men du var väldigt när. Försök igen!");
                    }
                    else
                    {
                        Console.WriteLine("Du gissade tyvärr för lågt, försök igen!");
                    }
                }

                else if (guess > random)
                {
                    if(guess < random + 6)
                    {
                        Console.WriteLine("Du gissade tyvärr för högt, men du var väldigt när. Försök igen!");
                    }
                    else
                    {
                        Console.WriteLine("Du gissade tyvärr för högt, förök igen!");
                    }
                }

                else
                {
                    Console.WriteLine($"Du gissade rätt, det tog dig {numberOfGuesses} försök!");
                }

                if (numberOfGuesses == 11)
                {
                    Console.WriteLine("Du har nått det maximala antalet gissningar!");
                    break;
                }

            } while (guess != random);


            Console.WriteLine();
            Console.WriteLine("Spelet är nu slut!");
            Console.WriteLine("Tryck Enter för att avsluta...");
            Console.ReadLine();

        }
    }
}