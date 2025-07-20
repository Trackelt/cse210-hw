class Choice
{
    private string _prompt;
    private List<String> _options;

    public Choice(string prompt, List<String> options)
    {
        _prompt = prompt;
        _options = options;
    }

    // This function takes the prompt and the list of options defined elsewhere, and prints out the list
    // and gets the users response, which can then be used to determine what happens.
    public int GetChoice()
    {
        Console.WriteLine(_prompt);
        for (int i = 0; i < _options.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_options[i]}");
        }

        int choice = 0;
        // This while loop makes it so that the user has to put in a number in-between
        // 1 and the number of options.
        while (choice < 1 || choice > _options.Count())
        {
            Console.Write("Enter your choice: ");
            string tempChoice = Console.ReadLine();
            if (int.TryParse(tempChoice, out choice))
            { }
            else
            {
                Console.WriteLine(" Please re-enter input.");
            }
        }
        return choice - 1;
    }
}