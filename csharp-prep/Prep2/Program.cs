using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string uInput = Console.ReadLine();
        int grade = int.Parse(uInput);
        string letter;
        if (grade >= 90)
        {
            //Console.WriteLine("Your grade is an A");
            letter = "A";
        }
        else if (grade >= 80)
        {
            //Console.WriteLine("Your grade is a B");
            letter = "B";
        }
        else if (grade >= 70)
        {
            //Console.WriteLine("Your grade is a C");
            letter = "C";
        }
        else if (grade >= 60)
        {
            //Console.WriteLine("Your grade is a D");
            letter = "D";
        }
        else 
        {
            //Console.WriteLine("Your grade is an F");
            letter = "F";
        }
        Console.WriteLine($"Your grade is {letter}");
        if (grade >= 70)
        {
            Console.WriteLine("You passed the class!");
        }
        else if (grade < 70)
        {
            Console.WriteLine("You didn't pass the class. Better luck next time!");
        }
    }
}