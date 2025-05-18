using System;
using System.IO.Enumeration;

class Program
{

    //private static string ObtainFileName(string prompt)
    //{
    //    Console.WriteLine(prompt);
    //    string fileName = Console.ReadLine();
    //    using (StreamWriter outputFile = new StreamWriter(fileName))
     //   {
       //     foreach (string p in _list)
         //   {
                    
         //   }
       // }
        //return fileName;

    //}
    static void Main(string[] args)
    {
        Entry newJournal = new Entry();
        List<string> newEntry = new List<string>();
        int response = 0;
        while (response != 5)
        {
            Console.WriteLine("1. New Journal Entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Read Journal from File");
            Console.WriteLine("4. Write Journal to File");
            Console.WriteLine("5. Quit");
            string response1 = Console.ReadLine();
            response = int.Parse(response1);
            if (response == 1)
            {
                Journal journalEntry = new Journal();
                newEntry = journalEntry.AddEntry(newEntry);

            }
            else if (response == 2)
            {
                newJournal.Display(newEntry);
            }
            else if (response == 3)
            {
                Console.WriteLine("Name of file to be loaded: ");
                string filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);
                if (File.Exists(filename))
                {
                    newEntry = new List<string>(File.ReadAllLines(filename));
                    
                    Console.WriteLine("File loaded successfully.");
                }
                else
                {
                    Console.WriteLine("File not found.");
                }



                //foreach (string line in lines)
                //{
                //    string[] parts = line.Split(",");

                //    string firstName = parts[0];
                //    string lastName = parts[1];
                //}

            }
            else if (response == 4)
            {
                Console.WriteLine("Name of new file: ");
                string fileName = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach (string e in newEntry)
                    {
                        outputFile.WriteLine(e);
                    }
                }

            }
            else if (response == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please reinput answer");
            }
        }
    }
}