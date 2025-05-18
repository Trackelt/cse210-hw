
public class Entry
{
    public string _date;
    public string _response;
    public string _entry;

    public void Display(List<string> entryList)
    {
        foreach (string e in entryList)
        {
            Console.WriteLine(e);
        }
    }

}