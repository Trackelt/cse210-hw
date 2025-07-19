class Boss : Enemy
{
    public Boss(string eName, int eMaxHP)
    : base(eName, eMaxHP)
    { }

    public override void EnAttack(Character target)
    {
        int dmg = 8;
        Console.WriteLine($"{_EName} attacks {target._Name} for {dmg} damage.");
        target.TakeDamage(dmg);
    }
}