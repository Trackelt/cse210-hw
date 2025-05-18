
using System.Globalization;

public class PromptGenerator
{
    public string _prompt;

    public string GeneratePrompt()
    {
        Random randomGenerator = new Random();
        int rNumber = randomGenerator.Next(1, 5);
        if (rNumber == 1)
        {
            _prompt = "Who was the most interesting person I interacted with today?";
        }
        else if (rNumber == 2)
        {
            _prompt = "What was the best part of my day?";
        }
        else if (rNumber == 3)
        {
            _prompt = "What did you eat today?";
        }
        else if (rNumber == 4)
        {
            _prompt = "What was the strongest emotion I felt today?";
        }
        else if (rNumber == 5)
        {
            _prompt = "If I had one thing I could do over today, what would it be?";
        }
        return _prompt;
    }
}