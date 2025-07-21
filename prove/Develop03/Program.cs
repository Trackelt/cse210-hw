using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";
        string subscript = "";
        Console.Clear();
        
        List<string> scriptList = new List<string> {"Wo unto the liar, for he shall be thrust down to hell.", "And now, I, Moroni, would speak somewhat concerning these things; I would show unto the world that faith is things which are hoped for and not seen; wherefore, dispute not because ye see not, for ye receive no witness until after the trial of your faith.", "And if men come unto me I will show unto them their weakness. I give unto men weakness that they may be humble; and my grace is sufficient for all men that humble themselves before me; for if they humble themselves before me, and have faith in me, then will I make weak things become strong unto them."};
        Scripture myScripture = new Scripture(scriptList);
        List<string> refList = new List<string> {"2 Nephi 9:34", "Ether 12:6", "Ether 12:27"};
        Reference myRef = new Reference(refList);
        Console.WriteLine("Choose a scripture:");
        int i = 0;
        foreach (string reference in myRef.GetRefList())
        {
            i++;
            Console.WriteLine($"{i}. {reference}");
        }
        
        int response;
        string response1 = Console.ReadLine();
        if (int.TryParse(response1, out response))
        {
            if (response < 1 || response > 3)
            {
                Console.WriteLine("Please re-enter number");
            }
            else
            {
                choice = myScripture.GetScriptList()[response - 1];
                subscript = myRef.GetRefList()[response - 1];
            }
        }
        else
        {
            Console.WriteLine("Please re-enter input");
        }
        
        Scripture split = new Scripture(subscript, choice);
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