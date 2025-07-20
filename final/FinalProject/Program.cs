using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        CenterText("NEW GAME");
        CenterText("Press enter to continue");
        Console.ReadLine();
        Console.Clear();
        // The program was having issues since it needs player defined, and it didn't like
        // that it was declared in an if statement, so I just made a blank player here.
        Character player;
        Console.Write("Enter Name: ");
        string playerName = Console.ReadLine();
        List<string> classOptions = new List<string> { "Mage", "Rogue", "Warrior" };
        Choice playerClass = new Choice("Which class would you like to be? ", classOptions);
        int classNumber = playerClass.GetChoice();
        if (classNumber == 0)
        {
            player = new Mage(playerName);
        }
        else if (classNumber == 1)
        {
            player = new Rogue(playerName);
        }
        else if (classNumber == 2)
        {
            player = new Warrior(playerName);
        }
        else
        {
            // This is because the system needs to think that player is defined,
            // and although it should never be able to choose an option not already
            // accounted for, it still thinks this needs to be here.
            player = new Warrior("Something went wrong");
        }

        List<string> direction = new List<string> { "Left", "Right", "Quit" };
        Choice directChoice = new Choice("Which direction do you go?", direction);
        while (player.IsCharacterAlive() == true)
        {
            Thread.Sleep(1000);
            Console.Clear();
            CenterText($"{player._Name} LV{player._Level}: {player._CurrentHP}/{player._MaxHP} HP, {player._CurrentFP}/{player._MaxFP} FP");
            Console.WriteLine("You see two directions ahead of you, one path going left and the other right.");
            Console.WriteLine("The path to the right looks more dangerous.");
            int directionChoice = directChoice.GetChoice();
            if (directionChoice == 0)
            {
                var (tempName, tempHP, tempXP, tempDMG) = Common.RandomStats();
                Enemy enemy1 = new Common(tempName, tempHP, tempXP, tempDMG);
                BattleSystem battle = new BattleSystem(player, enemy1);
                if (battle.StartBattle() == true)
                { }
                else
                {
                    break;
                }
            }
            else if (directionChoice == 1)
            {
                Enemy dragon = new Boss("dragon", 150, 200);
                BattleSystem battle = new BattleSystem(player, dragon);
                if (battle.StartBattle() == true)
                { }
                else
                {
                    break;
                }
            }
            else if (directionChoice == 2)
            {
                break;
            }
        }
    }

    // This function centers the text so that I can display some things in the center of the screen,
    // like the intro screen, and the player's info.
    public static void CenterText(string text)
    {
        // This gets the width of the console window and the lenght of the input text, subtracts them,
        // then divides by 2, so that it will be put in the middle of the screen.
        int windowWidth = Console.WindowWidth;
        int textLength = text.Length;
        int spaces = Math.Max((windowWidth - textLength) / 2, 0);
        Console.WriteLine(new string(' ', spaces) + text);
    }
}