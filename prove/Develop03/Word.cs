
public class Word
{
    

    public string HideWords(string[] list1, List<int> checker)
    {
        Random rand = new Random();
        int wordCount = list1.Length;
        
        for (int n=0; n<3; n++)
        {
            int i = rand.Next(0, wordCount);
            while (checker.Contains(i))
            {
                i = rand.Next(0, wordCount);
                if (checker.Count >= wordCount)
                {
                    break;
                }
            }
            
                checker.Add(i);
                list1[i] = new string('_', list1[i].Length);
        }
        
        return string.Join(" ", list1);
    }
}