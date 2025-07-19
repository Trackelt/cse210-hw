class BattleSystem
{
    private Character _player;
    private Enemy _enemy;
    public BattleSystem(Character player, Enemy enemy)
    {
        _player = player;
        _enemy = enemy;
    }
    public void StartBattle()
    {
        Console.WriteLine($"You encounter a {_enemy._EName}");
        List<string> options = new List<string> { "Attack", "Special Attack" };
        Choice myChoice = new Choice("What do you do?", options);

        while (_player.IsCharacterAlive() && _enemy.IsEnemyAlive())
        {
            Console.WriteLine($"{_player._Name}: {_player._CurrentHP}/{_player._MaxHP} HP, {_player._CurrentFP}/{_player._MaxFP} FP");
            Console.WriteLine($"{_enemy._EName}: {_enemy._ECurrentHP}/{_enemy._EMaxHP} HP");

            int selection = myChoice.GetChoice();

            if (selection == 0)
            {
                _player.Attack(_enemy);
            }
            else if (selection == 1)
            {
                _player.SpAttack(_enemy);
            }

            if (_enemy.IsEnemyAlive() == true)
            {
                _enemy.EnAttack(_player);
            }
        }

        if (_enemy.IsEnemyAlive() == false)
        {
            Console.WriteLine($"{_player._Name} defeated the {_enemy._EName}.");
        }
        else if (_player.IsCharacterAlive() == false)
        {
            Console.WriteLine($"{_player._Name} has fallen in battle.");
        }
        
    }
}