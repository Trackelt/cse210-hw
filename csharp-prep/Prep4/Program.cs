using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int uInput;
        int total = 0;
        Console.WriteLine("Enter a list of numbers. Type '0' when finished.");
        do
        { 
            Console.Write("Enter number: ");
            string uInput1 = Console.ReadLine();
            uInput = int.Parse(uInput1);
            if (uInput != 0)
            {
                numbers.Add(uInput);
            }
            total = total + uInput;
        } while (uInput != 0);
        Console.WriteLine($"The sum is: {total}");
        int length = numbers.Count();
        int average = total / length;
        Console.WriteLine($"The average is: {average}");
        int previous = 0;
        foreach (int number in numbers)
        {
            if (number > previous)
            {
                previous = number;
            }
        }
        Console.WriteLine($"The maximum is: {previous}");
    }
}