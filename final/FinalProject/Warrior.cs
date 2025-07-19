class Warrior : Character
{
    public Warrior(string name)
    : base(name, 120, 30)
    { }

    public override void Attack(Enemy target)
    {
        int dmg = 10;
        Console.WriteLine($"{_Name} attacks {target._EName} for {dmg} damage.");
        target.EnTakeDamage(dmg);
    }
    public override void SpAttack(Enemy target)
    {
        throw new NotImplementedException();
    }
}