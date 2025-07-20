class Warrior : Character
{
    // This is the warrior character class. It has more health, but less FP than the other classes.
    public Warrior(string name)
    : base(name, 120, 30)
    { }

    // This is the basic attack for the warrior, which will randomly do damage between 10 and 20.
    public override void Attack(Enemy target)
    {
        int baseDmg = 10;
        Random rand = new Random();
        // This gets a random double between 1.0 and 2.0, and then multiplies the base damage by it, and turns it back into an int.
        double dmgMultiplier = 1.0 + rand.NextDouble();
        int dmg = (int)(baseDmg * dmgMultiplier);
        Console.WriteLine($"{_Name} attacks the {target._EName} for {dmg} damage.");
        target.EnTakeDamage(dmg);
    }

    // This is the warrior's special attack, which does a good amount of damage and also heals them.
    public override void SpAttack(Enemy target)
    {
        int dmg = 40;
        bool able = UseFP(10);
        if (able == true)
        {
            Console.WriteLine($"{_Name} does a heavy attack, dealing {dmg} damage to the {target._EName}.");
            target.EnTakeDamage(dmg);
            Random rand = new Random();
            int baseHeal = 20;
            // This gets a random double between 1.0 and 2.0, and then multiplies the base healing by it, and turns it back into an int.
            double HPMultiplier = 1.0 + rand.NextDouble();
            int healAmount = (int)(baseHeal * HPMultiplier);
            Console.WriteLine($"{_Name} also recovers {healAmount} HP!");
            Heal(healAmount);
        }
        else
        {
            Console.WriteLine("You do not have enough FP to use this skill.");
        }
    }
}