class Rogue : Character
{
    public Rogue(string name)
    : base(name, 100, 40)
    { }
    
    public override void Attack(Enemy target)
    {
        throw new NotImplementedException();
    }
    public override void SpAttack(Enemy target)
    {
        throw new NotImplementedException();
    }
}