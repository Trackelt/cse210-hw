using System;

class Program
{
    static void Main(string[] args)
    {
        Character player = new Warrior("PC");
        Enemy bandit = new Boss("bandit", 100);
        BattleSystem battle = new BattleSystem(player, bandit);
        battle.StartBattle();
    }
}