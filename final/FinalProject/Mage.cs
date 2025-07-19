class Mage : Character
{
    public Mage(string name)
    : base(name, 80, 50)
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