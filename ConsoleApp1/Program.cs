// See https://aka.ms/new-console-template for more information
class Program
{
    public static void Main(string[] args)
    {
        WordCounter wordCounter = new WordCounter("This is a test");
        wordCounter.DisplayWords();
        int count = wordCounter.CountSingleWord("test");
        Console.WriteLine(count);
    }
}
