
public class Word
{
    

    public string HideWords(string[] list1, List<int> checker)
    {
        //int loopCount = 3;
        //int iteration = 0;
        Random rand = new Random();
        int wordCount = list1.Length;
        
        //while (iteration < loopCount)
        for (int n=0; n<3; n++)
        {
            int i = rand.Next(0, wordCount);
            while (checker.Contains(i))
            {
                //loopCount++;
                //Console.WriteLine($"checked {i}");
                //iteration++;
                i = rand.Next(0, wordCount);
                if (checker.Count >= wordCount)
                {
                    break;
                }
            }
            
            
                checker.Add(i);
                //Console.WriteLine(list1[i]);
                list1[i] = new string('_', list1[i].Length);
                //iteration++;
            
            
            

        }
        
        return string.Join(" ", list1);
    }
}