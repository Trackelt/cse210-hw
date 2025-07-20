class Mage : Character
{
    // This is the mage character class, which has a higher amount of FP, but less health than the other classes.
    public Mage(string name)
    : base(name, 80, 50)
    { }

    // This is the basic attack for the mage, which will do damage randomly between 5 and 15.
    public override void Attack(Enemy target)
    {
        int baseDmg = 5;
        Random rand = new Random();
        // This gets a random double between 1.0 and 3.0, and then multiplies the base damage by it, and turns it back into an int.
        double dmgMultiplier = 1.0 + (rand.NextDouble() * 2);
        int dmg = (int)(baseDmg * dmgMultiplier);
        Console.WriteLine($"{_Name} attacks the {target._EName} for {dmg} damage.");
        target.EnTakeDamage(dmg);
    }

    // This is the mage's special attack function. I was wanting to do something fancier, like allowing the player to
    // choose between different spells with it, but I couldn't really think of a good way to do it, so instead they
    // just cast one spell, which does a lot of damage.
    public override void SpAttack(Enemy target)
    {
        int dmg = 50;
        bool able = UseFP(10);
        if (able == true)
        {
            Console.WriteLine($"{_Name} casts a mighty fireball, dealing {dmg} damage to the {target._EName}.");
            target.EnTakeDamage(dmg);
        }
        else
        {
            Console.WriteLine("You do not have enough FP to use this skill.");
        }
    }
}