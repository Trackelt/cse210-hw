class Rogue : Character
{
    // This is the rogue character class. They have a moderate amount of HP and FP.
    public Rogue(string name)
    : base(name, 100, 40)
    { }

    // This is the basic attack for the rogue, which will do damage randomly between 7 and 21.
    public override void Attack(Enemy target)
    {
        int baseDmg = 7;
        Random rand = new Random();
        // This gets a random double between 1.0 and 3.0, and then multiplies the base damage by it, and turns it back into an int.
        double dmgMultiplier = 1.0 + (rand.NextDouble() * 2);
        int dmg = (int)(baseDmg * dmgMultiplier);
        Console.WriteLine($"{_Name} attacks the {target._EName} for {dmg} damage.");
        target.EnTakeDamage(dmg);
    }

    // This is the rogue's special attack. I thought it would be cool to make it so that it does a kind of critical hit,
    // so it does a good amount of base damage, and then multiplies it by a random number in-between 1 and 2, making it
    // so that it does somewhere between its base damage and double the damage.
    public override void SpAttack(Enemy target)
    {
        int baseDmg = 30;
        bool able = UseFP(10);
        if (able == true)
        {
            Random rand = new Random();
            // This gets a random double between 1.0 and 2.0, and then multiplies the base damage by it, and turns it back into an int.
            double critMultiplier = 1.0 + rand.NextDouble();
            int dmg = (int)(baseDmg * critMultiplier);
            Console.WriteLine($"{_Name} performs a precise stab, dealing {dmg} damage to the {target._EName}.");
            target.EnTakeDamage(dmg);
        }
        else
        {
            Console.WriteLine("You do not have enough FP to use this skill.");
        }
    }
}