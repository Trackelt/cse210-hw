class Common : Enemy
{
    int _DMG;
    public Common(string _eName, int _eMaxHP, int _givenXP, int dmg)
    : base(_eName, _eMaxHP, _givenXP)
    {
        _DMG = dmg;
    }

    // This is just a generaic attack that uses the enemy's name and damage value.
    public override void EnAttack(Character target)
    {
        Console.WriteLine($"The {_EName} attacks, dealing {_DMG} damage.");
        target.TakeDamage(_DMG);
    }

    // I thought it'd be cool to make it so that the enemy could be of different types, each with
    // their own stats, so I made this function which returns the information which can be made into
    // the enemy. I was running into problems with using it in the main program, so I had to make
    // it static so that it could be used easier.
    public static (string eName, int eMaxHP, int givenXP, int dmg) RandomStats()
    {
        string eName = "";
        int eMaxHP = 0;
        int givenXP = 0;
        int dmg = 0;
        Random rand = new Random();
        int type = rand.Next(1, 5);
        if (type == 1)
        {
            eName = "zombie";
            eMaxHP = 15;
            givenXP = 15;
            dmg = 7;
        }
        else if (type == 2)
        {
            eName = "skeleton";
            eMaxHP = 11;
            givenXP = 10;
            dmg = 10;
        }
        else if (type == 3)
        {
            eName = "slime";
            eMaxHP = 35;
            givenXP = 30;
            dmg = 3;
        }
        else if (type == 4)
        {
            eName = "ghost";
            eMaxHP = 35;
            givenXP = 50;
            dmg = 13;
        }
        return (eName, eMaxHP, givenXP, dmg);
    }
}