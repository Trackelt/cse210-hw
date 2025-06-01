using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        string subscript = "";
        Console.Clear();
        string script1 = "Wo unto the liar, for he shall be thrust down to hell.";
        string script2 = "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.";
        string script3 = "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them.";
        Console.WriteLine("Choose a scripture:");
        Console.WriteLine("1. 2 Nephi 9:34");
        Console.WriteLine("2. Ether 12:6");
        Console.WriteLine("3. Ether 12:27");
        string response1 = Console.ReadLine();
        int response = int.Parse(response1);
        if (response == 1)
        {
            choice = script1;
            subscript = "2 Nephi 9:34";
        }
        else if (response == 2)
        {
            choice = script2;
            subscript = "Ether 12:6";
        }
        else if (response == 3)
        {
            choice = script3;
            subscript = "Ether 12:27";
        }
        Reference split = new Reference();
        string[] phrase = split.SplitVerse(choice);
        int check = phrase.Length;
        Console.Clear();
        Console.WriteLine($"{subscript} {choice}");
        Console.Write("Press enter to continue or type 'quit' to finish:");
        List<int> checker = new List<int>();
        Word hide = new Word();
        while (check > 0)
        {
            string nChoice = Console.ReadLine();
            if (nChoice == "quit")
            {
                break;
            }
            else
            {
                Console.Clear();

                string final = hide.HideWords(phrase, checker);
                Console.WriteLine($"{subscript} {final}");
                check = check - 3;
                Console.Write("Press enter to continue or type 'quit' to finish:");
            }


        }
        
       
    }
}