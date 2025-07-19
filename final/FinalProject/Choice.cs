class Choice
{
    private string _prompt;
    private List<String> _options;

    public Choice(string prompt, List<String> options)
    {
        _prompt = prompt;
        _options = options;
    }
    public int GetChoice()
    {
        Console.WriteLine(_prompt);
        for (int i = 0; i < _options.Count(); i++)
        {
            Console.WriteLine($"{i + 1}. {_options[i]}");
        }

        int choice = 0;
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
        return choice -1;
    }
}