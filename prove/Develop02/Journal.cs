
public class Journal
{
    public List<string> _list;

    public List<string> AddEntry(List<string> entryList)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        PromptGenerator newPrompt = new PromptGenerator();
        string question = newPrompt.GeneratePrompt();
        Console.WriteLine($"{question}");
        string response = Console.ReadLine();
        entryList.Add(dateText);
        entryList.Add(question);
        entryList.Add(response);
        return entryList;
    }
}