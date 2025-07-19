class Common : Enemy
{
    public Common(string _eName, int _eMaxHP)
    : base(_eName, _eMaxHP)
    { }

    public override void EnAttack(Character target)
    {
        throw new NotImplementedException();
    }

    public void RandomStats()
    {
        //probably won't be a void return
    }
}