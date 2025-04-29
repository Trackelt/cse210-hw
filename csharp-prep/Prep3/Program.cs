using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.Write("What is the magic number? ");
        //string magic1 = Console.ReadLine();
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 100);
        //int magic = int.Parse(magic1);

        int guess;
        do
        {
            Console.Write("What is your guess? ");
            string guess1 = Console.ReadLine();
            guess = int.Parse(guess1);

            if (guess > magic)
            {
                Console.WriteLine("Lower");
            }
            else if (guess < magic)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("You guessed it!");
            }
        } while (guess != magic);
    }
}