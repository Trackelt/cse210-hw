using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment myAssignment = new Assignment("Bob", "Math");
        Console.WriteLine(myAssignment.GetSummary());

        MathAssignment myMath = new MathAssignment("James", "Imaginary numbers", "23", "50-61");
        Console.WriteLine(myMath.GetSummary());
        Console.WriteLine(myMath.GetHomeworkList());

        WritingAssignment myLit = new WritingAssignment("William", "Classics", "Romeo and Juliet");
        Console.WriteLine(myLit.GetSummary());
        Console.WriteLine(myLit.GetWritingAssignment());
    }
}