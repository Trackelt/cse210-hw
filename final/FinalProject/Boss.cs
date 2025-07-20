class Boss : Enemy
{
    public Boss(string _eName, int _eMaxHP, int _givenXP)
    : base(_eName, _eMaxHP, _givenXP)
    { }

    // This will need to change if I ever add any other bosses, but at the moment, the only planned boss
    // is a dragon, so this attack is more specifically for it.
    public override void EnAttack(Character target)
    {
        int dmg = 0;
        Random rand = new Random();
        int attackType = rand.Next(1, 4);
        // I thought it would be more interesting if the boss could do multiple attacks, so I had it
        // randomly pick between three different types, each one doing different amounts of damage.
        if (attackType == 1)
        {
            dmg = 20;
            Console.WriteLine($"The {_EName} slashes with its claws, dealing {dmg} damage.");
        }
        else if (attackType == 2)
        {
            dmg = 30;
            Console.WriteLine($"The {_EName} does a large tail slam, dealing {dmg} damage.");
        }
        else if (attackType == 3)
        {
            dmg = 40;
            Console.WriteLine($"The {_EName} spews fire from its mouth, dealing {dmg} damage.");
        }
        target.TakeDamage(dmg);
    }
}