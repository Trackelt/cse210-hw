class BattleSystem
{
    private Character _player;
    private Enemy _enemy;
    public BattleSystem(Character player, Enemy enemy)
    {
        _player = player;
        _enemy = enemy;
    }

    // This is the function that is used to start a battle between the player and an enemy, and it returns a
    // bool so that the program will be able to stop if the player dies.
    public bool StartBattle()
    {
        // I added this if statement cause it was having trouble, and would sometimes repeat this first part.
        if (_player.IsCharacterAlive() == true)
        {
            if (_enemy._EName == "zombie")
            {
                Console.WriteLine("You smell a horrid stench, and hear something shuffling around...");
            }
            else if (_enemy._EName == "skeleton")
            {
                Console.WriteLine("You hear the rattling of bones...");
            }
            else if (_enemy._EName == "slime")
            {
                Console.WriteLine("You hear a squelching sound...");
            }
            else if (_enemy._EName == "ghost")
            {
                Console.WriteLine("You feel a chill running down your back...");
            }
            else if (_enemy._EName == "dragon")
            {
                Console.WriteLine("The temperature starts rising rapidly...");
            }
            Thread.Sleep(500);
            Console.WriteLine($"You encounter a {_enemy._EName}!");
            List<string> options = new List<string> { "Attack", "Special Attack" };
            Choice myChoice = new Choice("What do you do?", options);
            Thread.Sleep(1000);

            // This while loop keeps the fight going until either the player or the enemy is dead.
            while (_player.IsCharacterAlive() && _enemy.IsEnemyAlive())
            {
                // This Thread.Sleep(1000) is here so that the player has time to read the text before it gets cleared away.
                // I also have several of these spread around so that the text doesn't just appear super fast, without
                // giving the player time to really read it. But timing is hard, so I don't really know if they are all
                // at good times to wait or not.
                Thread.Sleep(1000);
                // This Console.Clear() is here so that the screen doesn't get cluttered with all the turns.
                Console.Clear();
                // These next 2 lines will always display the player's and enemy's stats at the top of the screen, while in battle.
                Program.CenterText($"{_player._Name}: {_player._CurrentHP}/{_player._MaxHP} HP, {_player._CurrentFP}/{_player._MaxFP} FP");
                Program.CenterText($"{_enemy._EName}: {_enemy._ECurrentHP}/{_enemy._EMaxHP} HP");

                int selection = myChoice.GetChoice();

                if (selection == 0)
                {
                    _player.Attack(_enemy);
                }
                else if (selection == 1)
                {
                    _player.SpAttack(_enemy);
                }
                Thread.Sleep(500);

                // After the player attacks, it checks if the enemy died, and if not, then the enemy attacks.
                if (_enemy.IsEnemyAlive() == true)
                {
                    _enemy.EnAttack(_player);
                    Thread.Sleep(700);
                }
            }
        }
        

        // This sees if the enemy died, and if they did, it prints out a message then gives the player the XP.
        if (_enemy.IsEnemyAlive() == false)
        {
            Console.WriteLine($"{_player._Name} defeated the {_enemy._EName}.");
            _player.GainXP(_enemy._GivenXP);
            return true;
        }
        // If the player dies, then it will return false, so that the program can end.
        else if (_player.IsCharacterAlive() == false)
        {
            Console.WriteLine($"{_player._Name} has fallen in battle.");
            return false;
        }
        else
        {
            // This is needed because the function thinks that it needs to always have a return value, even though
            // the other to if statements should catch all possibilities.
            return false;
        }
    }
}